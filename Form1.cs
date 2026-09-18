using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Primero agregamos los datos a la lista
            personas.Add(new Persona(1, "Nancy Judith", "8711181633"));
            personas.Add(new Persona(2, "Yamilet Esmeralda", "8711181634"));
            personas.Add(new Persona(3, "Jorge Luis", "8711181635"));
            personas.Add(new Persona(4, "Jorge Luis", "8711181636"));

            // 2. Después recorremos la lista para pintarlos en la tabla
            foreach (var Persona in personas)
            {
                dgvInformacion.Rows.Add();
                dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = Persona.Id;
                dgvInformacion[1, dgvInformacion.Rows.Count - 1].Value = Persona.nombre;
                dgvInformacion[2, dgvInformacion.Rows.Count - 1].Value = Persona.telefono;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Add();
            dgvInformacion[0, dgvInformacion.Rows.Count - 1].Value = dgvInformacion.Rows.Count;
            dgvInformacion[1, dgvInformacion.Rows.Count - 1].Value = txtNombre.Text;
            dgvInformacion[2, dgvInformacion.Rows.Count - 1].Value = mtbTelefono.Text;
        }
    }
}