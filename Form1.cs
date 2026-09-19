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
        bool save = false; //indica si hay un archivo activo para guardar
        string path;

        public Form1()
        {
            InitializeComponent();
            guardarToolStripMenuItem.Enabled = false; // Inicia desactivado hasta que haya cambios
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofpAbrir.FileName;
                save = true; // Prendemos la bandera porque ya hay archivo activo
                rctTexto.LoadFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
               
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    path = sfdGuardar.FileName;
                    save = true; // Prendemos la bandera al guardar por primera vez
                }
                else
                {
                    return; // Si el usuario cancela, no hace nadota nadota jeje
                }
            }

            rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
            guardarToolStripMenuItem.Enabled = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
                save = true; // Prendemos la bandera
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctTexto.Clear();
            rctTexto.Focus();
            path = "";
            save = false; // Apagamos la bandera porque es un documento nuevo sin la ruta
            guardarToolStripMenuItem.Enabled = false;
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rctTexto_TextChanged(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = true; // Se activa la opción de guardar en el menú
            toolStripStatusLabel1.Text = "";         // Limpia el mensaje de la barra de estado
        }

        private void tmrAutoguardado_Tick(object sender, EventArgs e)
        {
            if (save == true && !String.IsNullOrEmpty(path))
            {
                // Guardado automático en segundo plano
                rctTexto.SaveFile(path, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;

                // Muestra el mensaje en tu StatusStrip
                toolStripStatusLabel1.Text = "Archivo guardado";
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
          
        }
    }
}