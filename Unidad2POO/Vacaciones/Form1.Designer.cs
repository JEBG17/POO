namespace Vacaciones
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
            this.lblAnio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVacacionesDeLaEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(12, 57);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(183, 13);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Años que ha trabajado en la empresa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnVacacionesDeLaEmpresa
            // 
            this.btnVacacionesDeLaEmpresa.Location = new System.Drawing.Point(75, 97);
            this.btnVacacionesDeLaEmpresa.Name = "btnVacacionesDeLaEmpresa";
            this.btnVacacionesDeLaEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnVacacionesDeLaEmpresa.TabIndex = 2;
            this.btnVacacionesDeLaEmpresa.Text = "Calcular";
            this.btnVacacionesDeLaEmpresa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVacacionesDeLaEmpresa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAnio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVacacionesDeLaEmpresa;
        private System.Windows.Forms.Label label2;
    }
}

