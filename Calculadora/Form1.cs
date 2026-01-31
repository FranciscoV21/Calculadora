using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
