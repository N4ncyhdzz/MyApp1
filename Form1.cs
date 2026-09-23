using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace MyApp
{
    public partial class Form1 : Form
    {
        string rutaArchivoCSV = "";
        List<Persona> registros = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoCSV = ofdCSV.FileName;
                var reader = new StreamReader(ofdCSV.FileName);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                registros = csv.GetRecords<Persona>().ToList();

                reader.Close();
                reader.Dispose();

                dgvRegistros.Rows.Clear();
                foreach (var registro in registros)
                {
                    dgvRegistros.Rows.Add(registro.id, registro.name, registro.email, null, null);

                }
            }

        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Form2 editar = new Form2(
                dgvRegistros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (editar.ShowDialog() == DialogResult.OK)
            {
                string nombre = editar.ActualizaNombre;
                string correo = editar.ActualizaCorreo;

                dgvRegistros.Rows[e.RowIndex].Cells[1].Value = nombre;
                dgvRegistros.Rows[e.RowIndex].Cells[2].Value = correo;

                registros[e.RowIndex].name = nombre;
                registros[e.RowIndex].email = correo;

                GuardarEnCSV();


            }
        }

        private void GuardarEnCSV()
        {
            if (!string.IsNullOrEmpty(rutaArchivoCSV))
            {
                using (var writer = new StreamWriter(rutaArchivoCSV))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(registros);
                }
            }
        }
    }
}
