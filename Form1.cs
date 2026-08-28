using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b = 0;
            a = Int32.Parse(txtNumero1.Text);
            b = Convert.ToInt32(txtNumero2.Text);

            //MessageBox.Show("La suma es: " + (a + b).ToString());

            txtResultado.Text = (a + b).ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar cajas de texto
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();


            //Situa el cursor en la caja indicada
            txtNumero1.Focus();
        }
    }
}
