namespace MyApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEjecucion = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(90, 35);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(75, 82);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(90, 133);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 82);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "0";
            // 
            // lblEjecucion
            // 
            this.lblEjecucion.AutoSize = true;
            this.lblEjecucion.Location = new System.Drawing.Point(2, 247);
            this.lblEjecucion.Name = "lblEjecucion";
            this.lblEjecucion.Size = new System.Drawing.Size(173, 20);
            this.lblEjecucion.TabIndex = 2;
            this.lblEjecucion.Text = "Tiempo en Ejecucion: 0";
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(634, 229);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(94, 35);
            this.btnEncender.TabIndex = 3;
            this.btnEncender.Text = "Enceder";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 276);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblEjecucion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReloj);
            this.Name = "Form1";
            this.Text = "Mi primer App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEjecucion;
        private System.Windows.Forms.Button btnEncender;
    }
}

