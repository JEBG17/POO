namespace MatrizSuma
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
			this.btnImprimir = new System.Windows.Forms.Button();
			this.txtSumaDiagonal = new System.Windows.Forms.TextBox();
			this.btnImpDiagonal = new System.Windows.Forms.Button();
			this.btnImpColumnas = new System.Windows.Forms.Button();
			this.txtSmaColum = new System.Windows.Forms.TextBox();
			this.btnImpFilas = new System.Windows.Forms.Button();
			this.txtSumaFilas = new System.Windows.Forms.TextBox();
			this.rtbMatriz = new System.Windows.Forms.RichTextBox();
			this.gbxTamaño = new System.Windows.Forms.GroupBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtTamaño = new System.Windows.Forms.TextBox();
			this.lblTamaño = new System.Windows.Forms.Label();
			this.gbxTamaño.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(230, 141);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 27;
			this.btnImprimir.Text = "Imprimir ";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// txtSumaDiagonal
			// 
			this.txtSumaDiagonal.Location = new System.Drawing.Point(501, 164);
			this.txtSumaDiagonal.Name = "txtSumaDiagonal";
			this.txtSumaDiagonal.Size = new System.Drawing.Size(138, 20);
			this.txtSumaDiagonal.TabIndex = 26;
			// 
			// btnImpDiagonal
			// 
			this.btnImpDiagonal.Location = new System.Drawing.Point(535, 93);
			this.btnImpDiagonal.Name = "btnImpDiagonal";
			this.btnImpDiagonal.Size = new System.Drawing.Size(75, 54);
			this.btnImpDiagonal.TabIndex = 25;
			this.btnImpDiagonal.Text = "Imprimir sumas de la diagonal";
			this.btnImpDiagonal.UseVisualStyleBackColor = true;
			this.btnImpDiagonal.Click += new System.EventHandler(this.btnImpDiagonal_Click);
			// 
			// btnImpColumnas
			// 
			this.btnImpColumnas.Location = new System.Drawing.Point(645, 15);
			this.btnImpColumnas.Name = "btnImpColumnas";
			this.btnImpColumnas.Size = new System.Drawing.Size(75, 54);
			this.btnImpColumnas.TabIndex = 24;
			this.btnImpColumnas.Text = "Imprimir sumas columnas";
			this.btnImpColumnas.UseVisualStyleBackColor = true;
			this.btnImpColumnas.Click += new System.EventHandler(this.btnImpColumnas_Click);
			// 
			// txtSmaColum
			// 
			this.txtSmaColum.Location = new System.Drawing.Point(501, 33);
			this.txtSmaColum.Name = "txtSmaColum";
			this.txtSmaColum.Size = new System.Drawing.Size(138, 20);
			this.txtSmaColum.TabIndex = 23;
			// 
			// btnImpFilas
			// 
			this.btnImpFilas.Location = new System.Drawing.Point(230, 186);
			this.btnImpFilas.Name = "btnImpFilas";
			this.btnImpFilas.Size = new System.Drawing.Size(75, 54);
			this.btnImpFilas.TabIndex = 22;
			this.btnImpFilas.Text = "Imprimir sumas filas ";
			this.btnImpFilas.UseVisualStyleBackColor = true;
			this.btnImpFilas.Click += new System.EventHandler(this.btnImpFilas_Click);
			// 
			// txtSumaFilas
			// 
			this.txtSumaFilas.Location = new System.Drawing.Point(327, 204);
			this.txtSumaFilas.Name = "txtSumaFilas";
			this.txtSumaFilas.Size = new System.Drawing.Size(138, 20);
			this.txtSumaFilas.TabIndex = 21;
			// 
			// rtbMatriz
			// 
			this.rtbMatriz.Location = new System.Drawing.Point(327, 33);
			this.rtbMatriz.Name = "rtbMatriz";
			this.rtbMatriz.Size = new System.Drawing.Size(138, 112);
			this.rtbMatriz.TabIndex = 20;
			this.rtbMatriz.Text = "";
			// 
			// gbxTamaño
			// 
			this.gbxTamaño.Controls.Add(this.btnAceptar);
			this.gbxTamaño.Controls.Add(this.txtTamaño);
			this.gbxTamaño.Controls.Add(this.lblTamaño);
			this.gbxTamaño.Location = new System.Drawing.Point(12, 33);
			this.gbxTamaño.Name = "gbxTamaño";
			this.gbxTamaño.Size = new System.Drawing.Size(267, 102);
			this.gbxTamaño.TabIndex = 19;
			this.gbxTamaño.TabStop = false;
			this.gbxTamaño.Text = "Tamaño";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(100, 56);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtTamaño
			// 
			this.txtTamaño.Location = new System.Drawing.Point(141, 30);
			this.txtTamaño.Name = "txtTamaño";
			this.txtTamaño.Size = new System.Drawing.Size(100, 20);
			this.txtTamaño.TabIndex = 1;
			// 
			// lblTamaño
			// 
			this.lblTamaño.AutoSize = true;
			this.lblTamaño.Location = new System.Drawing.Point(19, 30);
			this.lblTamaño.Name = "lblTamaño";
			this.lblTamaño.Size = new System.Drawing.Size(102, 13);
			this.lblTamaño.TabIndex = 0;
			this.lblTamaño.Text = "Tamaño de la matriz";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 279);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtSumaDiagonal);
			this.Controls.Add(this.btnImpDiagonal);
			this.Controls.Add(this.btnImpColumnas);
			this.Controls.Add(this.txtSmaColum);
			this.Controls.Add(this.btnImpFilas);
			this.Controls.Add(this.txtSumaFilas);
			this.Controls.Add(this.rtbMatriz);
			this.Controls.Add(this.gbxTamaño);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxTamaño.ResumeLayout(false);
			this.gbxTamaño.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.TextBox txtSumaDiagonal;
		private System.Windows.Forms.Button btnImpDiagonal;
		private System.Windows.Forms.Button btnImpColumnas;
		private System.Windows.Forms.TextBox txtSmaColum;
		private System.Windows.Forms.Button btnImpFilas;
		private System.Windows.Forms.TextBox txtSumaFilas;
		private System.Windows.Forms.RichTextBox rtbMatriz;
		private System.Windows.Forms.GroupBox gbxTamaño;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtTamaño;
		private System.Windows.Forms.Label lblTamaño;
	}
}

