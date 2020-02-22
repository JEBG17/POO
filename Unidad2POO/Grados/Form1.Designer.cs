namespace Grados
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
            this.lblGrados = new System.Windows.Forms.Label();
            this.txtNGrados = new System.Windows.Forms.TextBox();
            this.lblCentigrados = new System.Windows.Forms.Label();
            this.cmbGrados = new System.Windows.Forms.ComboBox();
            this.btnComvertir = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(54, 51);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(41, 13);
            this.lblGrados.TabIndex = 0;
            this.lblGrados.Text = "Grados";
            // 
            // txtNGrados
            // 
            this.txtNGrados.Location = new System.Drawing.Point(101, 48);
            this.txtNGrados.Name = "txtNGrados";
            this.txtNGrados.Size = new System.Drawing.Size(39, 20);
            this.txtNGrados.TabIndex = 1;
            // 
            // lblCentigrados
            // 
            this.lblCentigrados.AutoSize = true;
            this.lblCentigrados.Location = new System.Drawing.Point(54, 169);
            this.lblCentigrados.Name = "lblCentigrados";
            this.lblCentigrados.Size = new System.Drawing.Size(35, 13);
            this.lblCentigrados.TabIndex = 2;
            this.lblCentigrados.Text = "label2";
            // 
            // cmbGrados
            // 
            this.cmbGrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrados.FormattingEnabled = true;
            this.cmbGrados.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit"});
            this.cmbGrados.Location = new System.Drawing.Point(165, 48);
            this.cmbGrados.Name = "cmbGrados";
            this.cmbGrados.Size = new System.Drawing.Size(121, 21);
            this.cmbGrados.TabIndex = 3;
            // 
            // btnComvertir
            // 
            this.btnComvertir.Location = new System.Drawing.Point(211, 92);
            this.btnComvertir.Name = "btnComvertir";
            this.btnComvertir.Size = new System.Drawing.Size(75, 23);
            this.btnComvertir.TabIndex = 4;
            this.btnComvertir.Text = "Convertir";
            this.btnComvertir.UseVisualStyleBackColor = true;
            this.btnComvertir.Click += new System.EventHandler(this.btnComvertir_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(59, 241);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(35, 13);
            this.lblFahrenheit.TabIndex = 5;
            this.lblFahrenheit.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 392);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnComvertir);
            this.Controls.Add(this.cmbGrados);
            this.Controls.Add(this.lblCentigrados);
            this.Controls.Add(this.txtNGrados);
            this.Controls.Add(this.lblGrados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.TextBox txtNGrados;
        private System.Windows.Forms.Label lblCentigrados;
        private System.Windows.Forms.ComboBox cmbGrados;
        private System.Windows.Forms.Button btnComvertir;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

