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
        bool save = false;
        string path;

        public Form1()
        {
            InitializeComponent();
            guardarToolStripMenuItem.Enabled = false; // hace q inicie desactivado el botón de guardar
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofpAbrir.FileName;
                save = true; // Permite que el autoguardado funcione en este archivo abierto :)
                rctTexto.LoadFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false; // Se deshabilita al abrir un archivo, ya que no hay cambios pendientes
                lblStatus.Text = ""; // Limpia el status al abrir
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    path = sfdGuardar.FileName;
                    save = true;
                }
                else
                {
                    return; // Si el usuario cancela, no hace nadota
                }
            }

            rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
            guardarToolStripMenuItem.Enabled = false; // Se deshabilita al guardar 
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false; // Se deshabilita al guardar
                save = true;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            path = "";
            save = false;
            guardarToolStripMenuItem.Enabled = false;
            lblStatus.Text = ""; // Limpiamos el status al crear un archivo nuevo
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rctTexto_TextChanged(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = true; 
            lblStatus.Text = ""; // limpia el label cuando empiezas a escribir de nuevo
        }

        private void tmrAutoguardado_Tick(object sender, EventArgs e)
        {
            // Si hay un archivo abierto tmb autoguarda cada 30 segundos
            if (save == true && !String.IsNullOrEmpty(path))
            {
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false; // Vuelve a desactivar la opción en el menú
                lblStatus.Text = "Archivo guardado"; // Muestra el aviso
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
