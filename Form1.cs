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
        DateTime tiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.ToLongTimeString() == tiempo.ToLongTimeString())
            {
                Console.Beep(1000,200);
            }

        }

        private void configurarAlarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigurar ventanaAlarma = new frmConfigurar();

            if (ventanaAlarma.ShowDialog() == DialogResult.OK) 
            {
                tiempo = ventanaAlarma.hora;
                MessageBox.Show(tiempo.ToLongTimeString());
            }
        }
    }
}
