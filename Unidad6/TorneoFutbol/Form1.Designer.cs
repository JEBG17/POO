namespace TorneoFutbol
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
			this.gbxDatosTorneo = new System.Windows.Forms.GroupBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.nudEquipos = new System.Windows.Forms.NumericUpDown();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtNombreTorneo = new System.Windows.Forms.TextBox();
			this.lblNombreTorneo = new System.Windows.Forms.Label();
			this.lblNumeroEquipos = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxDatosTorneo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEquipos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatosTorneo
			// 
			this.gbxDatosTorneo.Controls.Add(this.btnImprimir);
			this.gbxDatosTorneo.Controls.Add(this.nudEquipos);
			this.gbxDatosTorneo.Controls.Add(this.btnAceptar);
			this.gbxDatosTorneo.Controls.Add(this.txtNombreTorneo);
			this.gbxDatosTorneo.Controls.Add(this.lblNombreTorneo);
			this.gbxDatosTorneo.Controls.Add(this.lblNumeroEquipos);
			this.gbxDatosTorneo.Location = new System.Drawing.Point(19, 12);
			this.gbxDatosTorneo.Name = "gbxDatosTorneo";
			this.gbxDatosTorneo.Size = new System.Drawing.Size(377, 105);
			this.gbxDatosTorneo.TabIndex = 8;
			this.gbxDatosTorneo.TabStop = false;
			this.gbxDatosTorneo.Text = "Datos ";
			// 
			// btnImprimir
			// 
			this.btnImprimir.Enabled = false;
			this.btnImprimir.Location = new System.Drawing.Point(296, 76);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 7;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// nudEquipos
			// 
			this.nudEquipos.Location = new System.Drawing.Point(123, 52);
			this.nudEquipos.Name = "nudEquipos";
			this.nudEquipos.Size = new System.Drawing.Size(49, 20);
			this.nudEquipos.TabIndex = 5;
			this.nudEquipos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(196, 76);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtNombreTorneo
			// 
			this.txtNombreTorneo.Location = new System.Drawing.Point(112, 19);
			this.txtNombreTorneo.Name = "txtNombreTorneo";
			this.txtNombreTorneo.Size = new System.Drawing.Size(100, 20);
			this.txtNombreTorneo.TabIndex = 0;
			// 
			// lblNombreTorneo
			// 
			this.lblNombreTorneo.AutoSize = true;
			this.lblNombreTorneo.Location = new System.Drawing.Point(12, 22);
			this.lblNombreTorneo.Name = "lblNombreTorneo";
			this.lblNombreTorneo.Size = new System.Drawing.Size(94, 13);
			this.lblNombreTorneo.TabIndex = 3;
			this.lblNombreTorneo.Text = "Nombre del torneo";
			// 
			// lblNumeroEquipos
			// 
			this.lblNumeroEquipos.AutoSize = true;
			this.lblNumeroEquipos.Location = new System.Drawing.Point(12, 52);
			this.lblNumeroEquipos.Name = "lblNumeroEquipos";
			this.lblNumeroEquipos.Size = new System.Drawing.Size(104, 13);
			this.lblNumeroEquipos.TabIndex = 4;
			this.lblNumeroEquipos.Text = "Números de equipos";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 132);
			this.Controls.Add(this.gbxDatosTorneo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxDatosTorneo.ResumeLayout(false);
			this.gbxDatosTorneo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEquipos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatosTorneo;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.NumericUpDown nudEquipos;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtNombreTorneo;
		private System.Windows.Forms.Label lblNombreTorneo;
		private System.Windows.Forms.Label lblNumeroEquipos;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

