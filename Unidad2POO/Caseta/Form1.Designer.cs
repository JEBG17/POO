namespace Caseta
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
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.lblPagoVehiculo = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(32, 47);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(50, 13);
            this.lblVehiculo.TabIndex = 0;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Motociclista",
            "Automóvil",
            "Autobús",
            "Tráiler"});
            this.cmbVehiculo.Location = new System.Drawing.Point(103, 44);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculo.TabIndex = 1;
            // 
            // lblPagoVehiculo
            // 
            this.lblPagoVehiculo.AutoSize = true;
            this.lblPagoVehiculo.Location = new System.Drawing.Point(32, 160);
            this.lblPagoVehiculo.Name = "lblPagoVehiculo";
            this.lblPagoVehiculo.Size = new System.Drawing.Size(0, 13);
            this.lblPagoVehiculo.TabIndex = 2;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(72, 103);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 272);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblPagoVehiculo);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.lblVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label lblPagoVehiculo;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

