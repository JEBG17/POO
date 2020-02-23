namespace Eectricidad
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
            this.lblTpo = new System.Windows.Forms.Label();
            this.cmbHogarNegocio = new System.Windows.Forms.ComboBox();
            this.lblKilowatts = new System.Windows.Forms.Label();
            this.txtKilowatts = new System.Windows.Forms.TextBox();
            this.btnCalcularPago = new System.Windows.Forms.Button();
            this.lblpagar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTpo
            // 
            this.lblTpo.AutoSize = true;
            this.lblTpo.Location = new System.Drawing.Point(44, 38);
            this.lblTpo.Name = "lblTpo";
            this.lblTpo.Size = new System.Drawing.Size(28, 13);
            this.lblTpo.TabIndex = 0;
            this.lblTpo.Text = "Tipo";
            // 
            // cmbHogarNegocio
            // 
            this.cmbHogarNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHogarNegocio.FormattingEnabled = true;
            this.cmbHogarNegocio.Items.AddRange(new object[] {
            "Hogar",
            "Negocio"});
            this.cmbHogarNegocio.Location = new System.Drawing.Point(106, 35);
            this.cmbHogarNegocio.Name = "cmbHogarNegocio";
            this.cmbHogarNegocio.Size = new System.Drawing.Size(121, 21);
            this.cmbHogarNegocio.TabIndex = 1;
            // 
            // lblKilowatts
            // 
            this.lblKilowatts.AutoSize = true;
            this.lblKilowatts.Location = new System.Drawing.Point(13, 95);
            this.lblKilowatts.Name = "lblKilowatts";
            this.lblKilowatts.Size = new System.Drawing.Size(108, 13);
            this.lblKilowatts.TabIndex = 2;
            this.lblKilowatts.Text = "Kilowatts consumidos";
            // 
            // txtKilowatts
            // 
            this.txtKilowatts.Location = new System.Drawing.Point(127, 92);
            this.txtKilowatts.Name = "txtKilowatts";
            this.txtKilowatts.Size = new System.Drawing.Size(100, 20);
            this.txtKilowatts.TabIndex = 3;
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.Location = new System.Drawing.Point(166, 129);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(75, 40);
            this.btnCalcularPago.TabIndex = 4;
            this.btnCalcularPago.Text = "Calcular pago";
            this.btnCalcularPago.UseVisualStyleBackColor = true;
            this.btnCalcularPago.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpagar
            // 
            this.lblpagar.AutoSize = true;
            this.lblpagar.Location = new System.Drawing.Point(47, 218);
            this.lblpagar.Name = "lblpagar";
            this.lblpagar.Size = new System.Drawing.Size(35, 13);
            this.lblpagar.TabIndex = 5;
            this.lblpagar.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 324);
            this.Controls.Add(this.lblpagar);
            this.Controls.Add(this.btnCalcularPago);
            this.Controls.Add(this.txtKilowatts);
            this.Controls.Add(this.lblKilowatts);
            this.Controls.Add(this.cmbHogarNegocio);
            this.Controls.Add(this.lblTpo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTpo;
        private System.Windows.Forms.ComboBox cmbHogarNegocio;
        private System.Windows.Forms.Label lblKilowatts;
        private System.Windows.Forms.TextBox txtKilowatts;
        private System.Windows.Forms.Button btnCalcularPago;
        private System.Windows.Forms.Label lblpagar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

