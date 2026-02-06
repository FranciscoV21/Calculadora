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
            string input = operaciones.Text; // Ejemplo: "1010 + FF - 20"
            string[] partes = Regex.Split(input, @"([\+\-\x\/])|\s+");
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
