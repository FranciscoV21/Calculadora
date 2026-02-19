using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DeshabilitarBotonesHexa();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;

            // Verificamos si es un operador
            bool esOperador = (botonPresionado == suma || botonPresionado == resta ||
                             botonPresionado == multiplicacion || botonPresionado == division || botonPresionado == Modulo || botonPresionado == raiz);

            if (esOperador)
            {
                EjecutarCalculo();

                operaciones.Text += botonPresionado.Text;

                // Al poner un operador, permitimos volver a elegir sistema (Hex/Bin) para el siguiente número
                hexa.Enabled = true;
                button2.Enabled = true;
                DeshabilitarBotonesHexa();
                HabilitarNumerosDecimales(true);
            }
            else
            {
                // Es un número (0-9)
                operaciones.Text += botonPresionado.Text;

                // Solo si no estamos escribiendo un número que ya empezó con 0x o 0b
                if (!operaciones.Text.EndsWith(botonPresionado.Text) ||
                    (!operaciones.Text.Contains("0x") && !operaciones.Text.Contains("0b")))
                {
                    hexa.Enabled = false;
                    button2.Enabled = false;
                }
            }
        }

        private void EjecutarCalculo()
        {
            if (string.IsNullOrWhiteSpace(operaciones.Text)) return;

            try
            {
                string input = operaciones.Text;
                string[] partes = Regex.Split(input, @"([+\-/%]|(?<!0)x)");

                double total = 0;
                string operadorActual = "+";

                foreach (string parte in partes)
                {
                    string token = parte.Trim();
                    if (string.IsNullOrEmpty(token)) continue;

                    if (token == "+" || token == "-" || token == "x" || token == "/" || token == "%")
                    {
                        operadorActual = token;
                    }
                    else
                    {
                        double valorConvertido = ConvertirADecimal(token);

                        switch (operadorActual)
                        {
                            case "+": total += valorConvertido; break;
                            case "-": total -= valorConvertido; break;
                            case "x": total *= valorConvertido; break;
                            case "/":
                                if (valorConvertido != 0) total /= valorConvertido;
                                break;
                            case "%": 
                                if (valorConvertido != 0) total %= valorConvertido;
                                break;
                        }
                    }
                }
                resultado.Text = total.ToString();
            }
            catch { /* Fallo silencioso */ }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            EjecutarCalculo();
            HabilitarTodosLosBotones();
            DeshabilitarBotonesHexa();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (operaciones.Text.Length > 0)
            {
                operaciones.Text = operaciones.Text.Substring(0, operaciones.Text.Length - 1);
                // Si borramos todo, rehabilitamos los botones de sistema
                if (operaciones.Text.Length == 0) HabilitarTodosLosBotones();
            }
        }

        private void operaciones_TextChanged(object sender, EventArgs e)
        {
            // Este método puede quedar vacío, pero DEBE existir para que no dé error CS1061
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {
            // Este método puede quedar vacío, pero DEBE existir para que no dé error CS1061
        }

        // --- LÓGICA DE SISTEMAS NUMÉRICOS ---
        private void hexa_Click(object sender, EventArgs e)
        {
            operaciones.Text += "0x";
            HabilitarLetrasHexa(true);
            button2.Enabled = false; // Bloqueamos binario
        }

        private void button2_Click(object sender, EventArgs e) // Botón Binario
        {
            operaciones.Text += "0b";
            HabilitarLetrasHexa(false);
            hexa.Enabled = false; // Bloqueamos hexadecimal
            HabilitarNumerosDecimales(false); // Solo dejamos 0 y 1
        }

        private double ConvertirADecimal(string numero)
        {
            string num = numero.ToLower();
            if (num.StartsWith("0x")) return Convert.ToInt64(num.Substring(2), 16);
            if (num.StartsWith("0b")) return Convert.ToInt64(num.Substring(2), 2);
            return double.Parse(num);
        }

        private void HabilitarLetrasHexa(bool estado)
        {
            ahexa.Enabled = bhexa.Enabled = chexa.Enabled =
            dhexa.Enabled = ehexa.Enabled = fhexa.Enabled = estado;
        }

        private void DeshabilitarBotonesHexa() => HabilitarLetrasHexa(false);

        private void HabilitarNumerosDecimales(bool estado)
        {
            dos.Enabled = tres.Enabled = cuatro.Enabled = cinco.Enabled =
            seis.Enabled = siete.Enabled = ocho.Enabled = nueve.Enabled = estado;
        }

        private void HabilitarTodosLosBotones()
        {
            hexa.Enabled = true;
            button2.Enabled = true;
            HabilitarNumerosDecimales(true);
        }

        private void Borrar_todo_Click(object sender, EventArgs e)
        {
            operaciones.Clear();
            resultado.Clear();
            HabilitarTodosLosBotones();
            DeshabilitarBotonesHexa();
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            // El módulo se comporta como una operación binaria (suma, resta, etc.)
            if (!string.IsNullOrEmpty(operaciones.Text))
            {
                EjecutarCalculo(); // Calculamos lo anterior antes de poner el símbolo
                operaciones.Text += "%";

                // Reset de estados para permitir cambiar de sistema en el siguiente número
                HabilitarTodosLosBotones();
                DeshabilitarBotonesHexa();
            }
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            // La raíz suele ser una operación inmediata sobre el resultado actual
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                try
                {
                    double valorActual = double.Parse(resultado.Text);
                    if (valorActual >= 0)
                    {
                        double r = Math.Sqrt(valorActual);
                        resultado.Text = r.ToString();
                        operaciones.Text = r.ToString(); // Actualizamos operaciones para seguir desde ahí
                    }
                    else
                    {
                        resultado.Text = "Error"; // No raíces negativas
                    }
                }
                catch { }
            }
        }
    }
}