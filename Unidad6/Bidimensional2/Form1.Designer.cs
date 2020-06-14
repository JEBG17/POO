namespace Bidimensional2
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
			this.lblIgual = new System.Windows.Forms.Label();
			this.lblMas = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.gbxOperaciones = new System.Windows.Forms.GroupBox();
			this.btnDivision = new System.Windows.Forms.Button();
			this.btnMultipliccion = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnSuma = new System.Windows.Forms.Button();
			this.gbxMatriz = new System.Windows.Forms.GroupBox();
			this.btnDatosB = new System.Windows.Forms.Button();
			this.btnDatosA = new System.Windows.Forms.Button();
			this.btnTamaño = new System.Windows.Forms.Button();
			this.gbxOperaciones.SuspendLayout();
			this.gbxMatriz.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblIgual
			// 
			this.lblIgual.AutoSize = true;
			this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIgual.Location = new System.Drawing.Point(483, 83);
			this.lblIgual.Name = "lblIgual";
			this.lblIgual.Size = new System.Drawing.Size(37, 39);
			this.lblIgual.TabIndex = 17;
			this.lblIgual.Text = "=";
			// 
			// lblMas
			// 
			this.lblMas.AutoSize = true;
			this.lblMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMas.Location = new System.Drawing.Point(334, 83);
			this.lblMas.Name = "lblMas";
			this.lblMas.Size = new System.Drawing.Size(37, 39);
			this.lblMas.TabIndex = 16;
			this.lblMas.Text = "+";
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(377, 58);
			this.txtB.Multiline = true;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 100);
			this.txtB.TabIndex = 15;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(526, 58);
			this.txtC.Multiline = true;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 100);
			this.txtC.TabIndex = 14;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(228, 58);
			this.txtA.Multiline = true;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 100);
			this.txtA.TabIndex = 13;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(544, 336);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 23);
			this.btnCerrar.TabIndex = 12;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(544, 288);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// gbxOperaciones
			// 
			this.gbxOperaciones.Controls.Add(this.btnDivision);
			this.gbxOperaciones.Controls.Add(this.btnMultipliccion);
			this.gbxOperaciones.Controls.Add(this.btnResta);
			this.gbxOperaciones.Controls.Add(this.btnSuma);
			this.gbxOperaciones.Location = new System.Drawing.Point(231, 279);
			this.gbxOperaciones.Name = "gbxOperaciones";
			this.gbxOperaciones.Size = new System.Drawing.Size(264, 110);
			this.gbxOperaciones.TabIndex = 10;
			this.gbxOperaciones.TabStop = false;
			this.gbxOperaciones.Text = "Operaciones ";
			// 
			// btnDivision
			// 
			this.btnDivision.Location = new System.Drawing.Point(146, 81);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(75, 23);
			this.btnDivision.TabIndex = 3;
			this.btnDivision.Text = "División";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
			// 
			// btnMultipliccion
			// 
			this.btnMultipliccion.Location = new System.Drawing.Point(28, 73);
			this.btnMultipliccion.Name = "btnMultipliccion";
			this.btnMultipliccion.Size = new System.Drawing.Size(86, 23);
			this.btnMultipliccion.TabIndex = 2;
			this.btnMultipliccion.Text = "Multiplicación ";
			this.btnMultipliccion.UseVisualStyleBackColor = true;
			this.btnMultipliccion.Click += new System.EventHandler(this.btnMultipliccion_Click);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(146, 34);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 23);
			this.btnResta.TabIndex = 1;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(28, 34);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(86, 23);
			this.btnSuma.TabIndex = 0;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
			// 
			// gbxMatriz
			// 
			this.gbxMatriz.Controls.Add(this.btnDatosB);
			this.gbxMatriz.Controls.Add(this.btnDatosA);
			this.gbxMatriz.Controls.Add(this.btnTamaño);
			this.gbxMatriz.Location = new System.Drawing.Point(12, 21);
			this.gbxMatriz.Name = "gbxMatriz";
			this.gbxMatriz.Size = new System.Drawing.Size(193, 256);
			this.gbxMatriz.TabIndex = 9;
			this.gbxMatriz.TabStop = false;
			this.gbxMatriz.Text = "Matriz Bidimensional";
			// 
			// btnDatosB
			// 
			this.btnDatosB.Location = new System.Drawing.Point(59, 165);
			this.btnDatosB.Name = "btnDatosB";
			this.btnDatosB.Size = new System.Drawing.Size(75, 39);
			this.btnDatosB.TabIndex = 2;
			this.btnDatosB.Text = "Ingresar\r\n datos B";
			this.btnDatosB.UseVisualStyleBackColor = true;
			this.btnDatosB.Click += new System.EventHandler(this.btnDatosB_Click);
			// 
			// btnDatosA
			// 
			this.btnDatosA.Location = new System.Drawing.Point(59, 99);
			this.btnDatosA.Name = "btnDatosA";
			this.btnDatosA.Size = new System.Drawing.Size(75, 41);
			this.btnDatosA.TabIndex = 1;
			this.btnDatosA.Text = "Ingresar\r\n datos A";
			this.btnDatosA.UseVisualStyleBackColor = true;
			this.btnDatosA.Click += new System.EventHandler(this.btnDatosA_Click);
			// 
			// btnTamaño
			// 
			this.btnTamaño.Location = new System.Drawing.Point(59, 26);
			this.btnTamaño.Name = "btnTamaño";
			this.btnTamaño.Size = new System.Drawing.Size(75, 41);
			this.btnTamaño.TabIndex = 0;
			this.btnTamaño.Text = "Tamaño\r\n  Matriz";
			this.btnTamaño.UseVisualStyleBackColor = true;
			this.btnTamaño.Click += new System.EventHandler(this.btnTamaño_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblIgual);
			this.Controls.Add(this.lblMas);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.gbxOperaciones);
			this.Controls.Add(this.gbxMatriz);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxOperaciones.ResumeLayout(false);
			this.gbxMatriz.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIgual;
		private System.Windows.Forms.Label lblMas;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.GroupBox gbxOperaciones;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Button btnMultipliccion;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.GroupBox gbxMatriz;
		private System.Windows.Forms.Button btnDatosB;
		private System.Windows.Forms.Button btnDatosA;
		private System.Windows.Forms.Button btnTamaño;
	}
}

