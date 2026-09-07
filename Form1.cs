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
        int contador = 0,minutos=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            contador++;
            DateTime tiempo= DateTime.Now;
            lblReloj.Text = tiempo.ToString("HH:mm:ss");
            lblFecha.Text = tiempo.ToString("MM-dd-yyyy");
            if (contador == 60)
            {
                minutos++;
                contador = 0;
            }
            lblEjecucion.Text = "Tiempo en Ejecucion: " + minutos.ToString();

        }
    }
}
