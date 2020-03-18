namespace FigurasGeometricas1
{
    partial class FTriangulo
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
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.cmbTriangulos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(3, 33);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(86, 13);
            this.lblTriangulo.TabIndex = 0;
            this.lblTriangulo.Text = "Tipo de triangulo";
            this.lblTriangulo.Click += new System.EventHandler(this.lblTriangulo_Click);
            // 
            // cmbTriangulos
            // 
            this.cmbTriangulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriangulos.FormattingEnabled = true;
            this.cmbTriangulos.Items.AddRange(new object[] {
            "Equilátero",
            "Escaleno",
            "Isósceles"});
            this.cmbTriangulos.Location = new System.Drawing.Point(95, 30);
            this.cmbTriangulos.Name = "cmbTriangulos";
            this.cmbTriangulos.Size = new System.Drawing.Size(121, 21);
            this.cmbTriangulos.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(69, 57);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 95);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTriangulos);
            this.Controls.Add(this.lblTriangulo);
            this.Name = "FTriangulo";
            this.Text = "Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.ComboBox cmbTriangulos;
        private System.Windows.Forms.Button btnAceptar;
    }
}