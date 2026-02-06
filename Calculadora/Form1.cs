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
            ahexa.Enabled = false;
            bhexa.Enabled = false;
            chexa.Enabled = false;
            dhexa.Enabled = false;
            ehexa.Enabled = false;
            fhexa.Enabled = false;
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            // Convertimos el ¨sender¨ en un Boton para acceder a sus propiedades
            Button botonPresionado = (Button)sender;

            // Usamos el Texto del botón (que ya es "1", "2", etc.) 
            // y lo añadimos al textBox
            operaciones.Text += botonPresionado.Text;
        }
        private void igual_Click(object sender, EventArgs e)
        {
            try
            {
                string input = operaciones.Text;
                // 1. Separamos los números de los operadores
                string[] partes = Regex.Split(input, @"([+\-x/])");

                double total = 0;
                string operadorActual = "+"; // Empezamos sumando el primer número al total (0)

                foreach (string parte in partes)
                {
                    string token = parte.Trim(); // Quitamos los espacios que pusiste para que se vea bonito
                    if (string.IsNullOrEmpty(token)) continue;

                    // 2. CORRECCIÓN: Comprobamos si es un operador de forma directa
                    if (token == "+" || token == "-" || token == "x" || token == "/")
                    {
                        operadorActual = token;
                    }
                    else
                    {
                        // 3. Es un número, lo convertimos y aplicamos la operación
                        double valorConvertido = ConvertirADecimal(token);

                        switch (operadorActual)
                        {
                            case "+": total += valorConvertido; break;
                            case "-": total -= valorConvertido; break;
                            case "x": total *= valorConvertido; break;
                            case "/":
                                if (valorConvertido != 0) total /= valorConvertido;
                                else { MessageBox.Show("No se puede dividir por cero"); return; }
                                break;
                        }
                    }
                }

                // 4. Mostramos el resultado
                resultado.Text = total.ToString();

                // TIP: Re-habilitamos todos los botones para la siguiente operación
                HabilitarTodosLosBotones();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de formato. Asegúrate de usar bien los prefijos 0x o 0b.");
            }
        }
        private void HabilitarTodosLosBotones()
        {
            ahexa.Enabled = true; bhexa.Enabled = true; chexa.Enabled = true;
            dhexa.Enabled = true; ehexa.Enabled = true; fhexa.Enabled = true;
            dos.Enabled = true; tres.Enabled = true; cuatro.Enabled = true;
            cinco.Enabled = true; seis.Enabled = true; siete.Enabled = true;
            ocho.Enabled = true; nueve.Enabled = true;
            button2.Enabled = true; // Botón Binario
        }

        private double ConvertirADecimal(string numero)
        {
            // Usamos .ToLower() para que acepte 0X o 0x por igual
            string num = numero.ToLower();

            if (num.StartsWith("0x"))
            {
                // Hexadecimal
                return Convert.ToInt64(num.Substring(2), 16);
            }
            else if (num.StartsWith("0b"))
            {
                // Binario
                return Convert.ToInt64(num.Substring(2), 2);
            }
            else
            {
                // Decimal (aseguramos que no haya letras accidentales)
                return double.Parse(num);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
                       if (operaciones.Text.Length > 0)
            {
                operaciones.Text = operaciones.Text.Substring(0, operaciones.Text.Length - 1);
            }

        }

        private void hexa_Click(object sender, EventArgs e)
        {
            operaciones.Text += "0x";
            ahexa.Enabled = true;
            bhexa.Enabled = true;
            chexa.Enabled = true;
            dhexa.Enabled = true;
            ehexa.Enabled = true;
            fhexa.Enabled = true;
             button2.Enabled = true; // Habilitar el botón Binario

        }

        private void button2_Click(object sender, EventArgs e) // Botón Binario
        {
            operaciones.Text += "0b";
            // Bloquear botones (A-F y 2-9)
            ahexa.Enabled = false;
            bhexa.Enabled = false;
            chexa.Enabled = false;
            dhexa.Enabled = false;
            ehexa.Enabled = false;
            fhexa.Enabled = false;
            button2.Enabled = false; // Deshabilitar el botón Binario para evitar múltiples "0b"
            dos.Enabled = false;
            tres.Enabled = false;
            cuatro.Enabled = false;
            cinco.Enabled = false;
            seis.Enabled = false;
            siete.Enabled = false;
            ocho.Enabled = false;
            nueve.Enabled = false;
        }

        private void operaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
