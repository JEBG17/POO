namespace Transportes
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
			this.gbxDatosEmpresas = new System.Windows.Forms.GroupBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.nudNumConductores = new System.Windows.Forms.NumericUpDown();
			this.lblNumConductores = new System.Windows.Forms.Label();
			this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
			this.lblNnombreEmpresa = new System.Windows.Forms.Label();
			this.gbxDatosConductores = new System.Windows.Forms.GroupBox();
			this.btnCapturar = new System.Windows.Forms.Button();
			this.txtNombreConductor = new System.Windows.Forms.TextBox();
			this.lblNomConductor = new System.Windows.Forms.Label();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaMi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbxDatosEmpresas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumConductores)).BeginInit();
			this.gbxDatosConductores.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxDatosEmpresas
			// 
			this.gbxDatosEmpresas.Controls.Add(this.btnAceptar);
			this.gbxDatosEmpresas.Controls.Add(this.nudNumConductores);
			this.gbxDatosEmpresas.Controls.Add(this.lblNumConductores);
			this.gbxDatosEmpresas.Controls.Add(this.txtNombreEmpresa);
			this.gbxDatosEmpresas.Controls.Add(this.lblNnombreEmpresa);
			this.gbxDatosEmpresas.Location = new System.Drawing.Point(22, 35);
			this.gbxDatosEmpresas.Name = "gbxDatosEmpresas";
			this.gbxDatosEmpresas.Size = new System.Drawing.Size(367, 120);
			this.gbxDatosEmpresas.TabIndex = 0;
			this.gbxDatosEmpresas.TabStop = false;
			this.gbxDatosEmpresas.Text = "Datos generales de la empresa";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(238, 73);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar ";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// nudNumConductores
			// 
			this.nudNumConductores.Location = new System.Drawing.Point(156, 61);
			this.nudNumConductores.Name = "nudNumConductores";
			this.nudNumConductores.Size = new System.Drawing.Size(37, 20);
			this.nudNumConductores.TabIndex = 3;
			// 
			// lblNumConductores
			// 
			this.lblNumConductores.AutoSize = true;
			this.lblNumConductores.Location = new System.Drawing.Point(21, 61);
			this.lblNumConductores.Name = "lblNumConductores";
			this.lblNumConductores.Size = new System.Drawing.Size(129, 13);
			this.lblNumConductores.TabIndex = 2;
			this.lblNumConductores.Text = "Numeros de conductores ";
			// 
			// txtNombreEmpresa
			// 
			this.txtNombreEmpresa.Location = new System.Drawing.Point(156, 29);
			this.txtNombreEmpresa.Name = "txtNombreEmpresa";
			this.txtNombreEmpresa.Size = new System.Drawing.Size(157, 20);
			this.txtNombreEmpresa.TabIndex = 1;
			// 
			// lblNnombreEmpresa
			// 
			this.lblNnombreEmpresa.AutoSize = true;
			this.lblNnombreEmpresa.Location = new System.Drawing.Point(22, 36);
			this.lblNnombreEmpresa.Name = "lblNnombreEmpresa";
			this.lblNnombreEmpresa.Size = new System.Drawing.Size(116, 13);
			this.lblNnombreEmpresa.TabIndex = 0;
			this.lblNnombreEmpresa.Text = "Nombre de la empresa ";
			// 
			// gbxDatosConductores
			// 
			this.gbxDatosConductores.Controls.Add(this.btnCapturar);
			this.gbxDatosConductores.Controls.Add(this.txtNombreConductor);
			this.gbxDatosConductores.Controls.Add(this.lblNomConductor);
			this.gbxDatosConductores.Location = new System.Drawing.Point(22, 175);
			this.gbxDatosConductores.Name = "gbxDatosConductores";
			this.gbxDatosConductores.Size = new System.Drawing.Size(367, 116);
			this.gbxDatosConductores.TabIndex = 5;
			this.gbxDatosConductores.TabStop = false;
			this.gbxDatosConductores.Text = "Datos conductores ";
			// 
			// btnCapturar
			// 
			this.btnCapturar.Location = new System.Drawing.Point(273, 72);
			this.btnCapturar.Name = "btnCapturar";
			this.btnCapturar.Size = new System.Drawing.Size(75, 23);
			this.btnCapturar.TabIndex = 4;
			this.btnCapturar.Text = "Capturar";
			this.btnCapturar.UseVisualStyleBackColor = true;
			this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
			// 
			// txtNombreConductor
			// 
			this.txtNombreConductor.Location = new System.Drawing.Point(156, 33);
			this.txtNombreConductor.Name = "txtNombreConductor";
			this.txtNombreConductor.Size = new System.Drawing.Size(157, 20);
			this.txtNombreConductor.TabIndex = 1;
			// 
			// lblNomConductor
			// 
			this.lblNomConductor.AutoSize = true;
			this.lblNomConductor.Location = new System.Drawing.Point(22, 36);
			this.lblNomConductor.Name = "lblNomConductor";
			this.lblNomConductor.Size = new System.Drawing.Size(115, 13);
			this.lblNomConductor.TabIndex = 0;
			this.lblNomConductor.Text = "Nombre del conductor ";
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DiaL,
            this.DiaM,
            this.DiaMi,
            this.DiaJ,
            this.DiaV,
            this.DiaS,
            this.DiaD});
			this.dgvDatos.Location = new System.Drawing.Point(12, 314);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(519, 150);
			this.dgvDatos.TabIndex = 6;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(456, 259);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 7;
			this.btnImprimir.Text = "Iimprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre empleado";
			this.Nombre.Name = "Nombre";
			// 
			// DiaL
			// 
			this.DiaL.HeaderText = "Lunes";
			this.DiaL.Name = "DiaL";
			// 
			// DiaM
			// 
			this.DiaM.HeaderText = "Martes";
			this.DiaM.Name = "DiaM";
			// 
			// DiaMi
			// 
			this.DiaMi.HeaderText = "Miercoles";
			this.DiaMi.Name = "DiaMi";
			// 
			// DiaJ
			// 
			this.DiaJ.HeaderText = "Jueves";
			this.DiaJ.Name = "DiaJ";
			// 
			// DiaV
			// 
			this.DiaV.HeaderText = "Viernes";
			this.DiaV.Name = "DiaV";
			// 
			// DiaS
			// 
			this.DiaS.HeaderText = "Sabado";
			this.DiaS.Name = "DiaS";
			// 
			// DiaD
			// 
			this.DiaD.HeaderText = "Domingo";
			this.DiaD.Name = "DiaD";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 488);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.gbxDatosConductores);
			this.Controls.Add(this.gbxDatosEmpresas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.gbxDatosEmpresas.ResumeLayout(false);
			this.gbxDatosEmpresas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumConductores)).EndInit();
			this.gbxDatosConductores.ResumeLayout(false);
			this.gbxDatosConductores.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDatosEmpresas;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.NumericUpDown nudNumConductores;
		private System.Windows.Forms.Label lblNumConductores;
		private System.Windows.Forms.TextBox txtNombreEmpresa;
		private System.Windows.Forms.Label lblNnombreEmpresa;
		private System.Windows.Forms.GroupBox gbxDatosConductores;
		private System.Windows.Forms.TextBox txtNombreConductor;
		private System.Windows.Forms.Label lblNomConductor;
		private System.Windows.Forms.Button btnCapturar;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaL;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaM;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaMi;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaJ;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaS;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaD;
	}
}

