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
    public partial class Form2 : Form
    {
        public Form2(string nombre, string correo)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtCorreo.Text = correo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
