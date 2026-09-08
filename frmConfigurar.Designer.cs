namespace MyApp
{
    partial class frmConfigurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpConfigura = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpConfigura
            // 
            this.dtpConfigura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpConfigura.Location = new System.Drawing.Point(30, 27);
            this.dtpConfigura.Name = "dtpConfigura";
            this.dtpConfigura.ShowUpDown = true;
            this.dtpConfigura.Size = new System.Drawing.Size(194, 26);
            this.dtpConfigura.TabIndex = 0;
            this.dtpConfigura.Value = new System.DateTime(2026, 9, 8, 15, 17, 0, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 86);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpConfigura);
            this.Name = "frmConfigurar";
            this.Text = "Configurar Alarma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpConfigura;
        private System.Windows.Forms.Button btnAceptar;
    }
}