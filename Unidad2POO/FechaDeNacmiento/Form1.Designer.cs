namespace FechaDeNacmiento
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAnioNacimiento = new System.Windows.Forms.Label();
            this.btnSaber = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 51);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblAnioNacimiento
            // 
            this.lblAnioNacimiento.AutoSize = true;
            this.lblAnioNacimiento.Location = new System.Drawing.Point(18, 51);
            this.lblAnioNacimiento.Name = "lblAnioNacimiento";
            this.lblAnioNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblAnioNacimiento.TabIndex = 1;
            this.lblAnioNacimiento.Text = "Fecha de nacimiento";
            // 
            // btnSaber
            // 
            this.btnSaber.Location = new System.Drawing.Point(90, 109);
            this.btnSaber.Name = "btnSaber";
            this.btnSaber.Size = new System.Drawing.Size(75, 23);
            this.btnSaber.TabIndex = 2;
            this.btnSaber.Text = "Saber";
            this.btnSaber.UseVisualStyleBackColor = true;
            this.btnSaber.Click += new System.EventHandler(this.btnSaber_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(46, 194);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 295);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSaber);
            this.Controls.Add(this.lblAnioNacimiento);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblAnioNacimiento;
        private System.Windows.Forms.Button btnSaber;
        private System.Windows.Forms.Label lblResultado;
    }
}

