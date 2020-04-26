namespace PaicesNo1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblPais = new System.Windows.Forms.Label();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.btnGiardarImprimir = new System.Windows.Forms.Button();
			this.txtPoblacion = new System.Windows.Forms.TextBox();
			this.lblPoblacion = new System.Windows.Forms.Label();
			this.txtIidioma = new System.Windows.Forms.TextBox();
			this.lblIdioma = new System.Windows.Forms.Label();
			this.txtColor1 = new System.Windows.Forms.TextBox();
			this.lblColores = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtColor3 = new System.Windows.Forms.TextBox();
			this.txtColor2 = new System.Windows.Forms.TextBox();
			this.gbxDATOSpaises = new System.Windows.Forms.GroupBox();
			this.lblDColores = new System.Windows.Forms.Label();
			this.lblDIdioma = new System.Windows.Forms.Label();
			this.lblDPoblacion = new System.Windows.Forms.Label();
			this.lblDNombre = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.gbxDATOSpaises.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPais
			// 
			this.lblPais.AutoSize = true;
			this.lblPais.Location = new System.Drawing.Point(22, 34);
			this.lblPais.Name = "lblPais";
			this.lblPais.Size = new System.Drawing.Size(87, 13);
			this.lblPais.TabIndex = 0;
			this.lblPais.Text = "Nombre del Pais:";
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(141, 31);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(197, 20);
			this.txtPais.TabIndex = 1;
			// 
			// btnGiardarImprimir
			// 
			this.btnGiardarImprimir.Location = new System.Drawing.Point(263, 260);
			this.btnGiardarImprimir.Name = "btnGiardarImprimir";
			this.btnGiardarImprimir.Size = new System.Drawing.Size(75, 43);
			this.btnGiardarImprimir.TabIndex = 2;
			this.btnGiardarImprimir.Text = "Guardar \r\nImprimir";
			this.btnGiardarImprimir.UseVisualStyleBackColor = true;
			this.btnGiardarImprimir.Click += new System.EventHandler(this.btnGiardarImprimir_Click);
			// 
			// txtPoblacion
			// 
			this.txtPoblacion.Location = new System.Drawing.Point(141, 67);
			this.txtPoblacion.Name = "txtPoblacion";
			this.txtPoblacion.Size = new System.Drawing.Size(197, 20);
			this.txtPoblacion.TabIndex = 5;
			// 
			// lblPoblacion
			// 
			this.lblPoblacion.AutoSize = true;
			this.lblPoblacion.Location = new System.Drawing.Point(22, 70);
			this.lblPoblacion.Name = "lblPoblacion";
			this.lblPoblacion.Size = new System.Drawing.Size(97, 13);
			this.lblPoblacion.TabIndex = 4;
			this.lblPoblacion.Text = "Poblacion del Pais:";
			// 
			// txtIidioma
			// 
			this.txtIidioma.Location = new System.Drawing.Point(141, 102);
			this.txtIidioma.Name = "txtIidioma";
			this.txtIidioma.Size = new System.Drawing.Size(197, 20);
			this.txtIidioma.TabIndex = 7;
			// 
			// lblIdioma
			// 
			this.lblIdioma.AutoSize = true;
			this.lblIdioma.Location = new System.Drawing.Point(22, 105);
			this.lblIdioma.Name = "lblIdioma";
			this.lblIdioma.Size = new System.Drawing.Size(108, 13);
			this.lblIdioma.TabIndex = 6;
			this.lblIdioma.Text = "Idioma predominante:";
			// 
			// txtColor1
			// 
			this.txtColor1.Location = new System.Drawing.Point(192, 19);
			this.txtColor1.Name = "txtColor1";
			this.txtColor1.Size = new System.Drawing.Size(121, 20);
			this.txtColor1.TabIndex = 9;
			// 
			// lblColores
			// 
			this.lblColores.AutoSize = true;
			this.lblColores.Location = new System.Drawing.Point(6, 48);
			this.lblColores.Name = "lblColores";
			this.lblColores.Size = new System.Drawing.Size(174, 13);
			this.lblColores.TabIndex = 8;
			this.lblColores.Text = "3 colores principales de su bandera";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtColor3);
			this.groupBox1.Controls.Add(this.txtColor2);
			this.groupBox1.Controls.Add(this.txtColor1);
			this.groupBox1.Controls.Add(this.lblColores);
			this.groupBox1.Location = new System.Drawing.Point(25, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(319, 113);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Colores de la bandera ";
			// 
			// txtColor3
			// 
			this.txtColor3.Location = new System.Drawing.Point(192, 71);
			this.txtColor3.Name = "txtColor3";
			this.txtColor3.Size = new System.Drawing.Size(121, 20);
			this.txtColor3.TabIndex = 11;
			// 
			// txtColor2
			// 
			this.txtColor2.Location = new System.Drawing.Point(192, 45);
			this.txtColor2.Name = "txtColor2";
			this.txtColor2.Size = new System.Drawing.Size(121, 20);
			this.txtColor2.TabIndex = 10;
			// 
			// gbxDATOSpaises
			// 
			this.gbxDATOSpaises.Controls.Add(this.lblDColores);
			this.gbxDATOSpaises.Controls.Add(this.lblDIdioma);
			this.gbxDATOSpaises.Controls.Add(this.lblDPoblacion);
			this.gbxDATOSpaises.Controls.Add(this.lblDNombre);
			this.gbxDATOSpaises.Location = new System.Drawing.Point(420, 4);
			this.gbxDATOSpaises.Name = "gbxDATOSpaises";
			this.gbxDATOSpaises.Size = new System.Drawing.Size(298, 238);
			this.gbxDATOSpaises.TabIndex = 11;
			this.gbxDATOSpaises.TabStop = false;
			this.gbxDATOSpaises.Text = "Datos del pais introducido ";
			// 
			// lblDColores
			// 
			this.lblDColores.AutoSize = true;
			this.lblDColores.Location = new System.Drawing.Point(6, 137);
			this.lblDColores.Name = "lblDColores";
			this.lblDColores.Size = new System.Drawing.Size(0, 13);
			this.lblDColores.TabIndex = 3;
			// 
			// lblDIdioma
			// 
			this.lblDIdioma.AutoSize = true;
			this.lblDIdioma.Location = new System.Drawing.Point(6, 98);
			this.lblDIdioma.Name = "lblDIdioma";
			this.lblDIdioma.Size = new System.Drawing.Size(0, 13);
			this.lblDIdioma.TabIndex = 2;
			// 
			// lblDPoblacion
			// 
			this.lblDPoblacion.AutoSize = true;
			this.lblDPoblacion.Location = new System.Drawing.Point(6, 63);
			this.lblDPoblacion.Name = "lblDPoblacion";
			this.lblDPoblacion.Size = new System.Drawing.Size(0, 13);
			this.lblDPoblacion.TabIndex = 1;
			// 
			// lblDNombre
			// 
			this.lblDNombre.AutoSize = true;
			this.lblDNombre.Location = new System.Drawing.Point(6, 30);
			this.lblDNombre.Name = "lblDNombre";
			this.lblDNombre.Size = new System.Drawing.Size(0, 13);
			this.lblDNombre.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 328);
			this.Controls.Add(this.gbxDATOSpaises);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtIidioma);
			this.Controls.Add(this.lblIdioma);
			this.Controls.Add(this.txtPoblacion);
			this.Controls.Add(this.lblPoblacion);
			this.Controls.Add(this.btnGiardarImprimir);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.lblPais);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Paises";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbxDATOSpaises.ResumeLayout(false);
			this.gbxDATOSpaises.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPais;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.Button btnGiardarImprimir;
		private System.Windows.Forms.TextBox txtPoblacion;
		private System.Windows.Forms.Label lblPoblacion;
		private System.Windows.Forms.TextBox txtIidioma;
		private System.Windows.Forms.Label lblIdioma;
		private System.Windows.Forms.TextBox txtColor1;
		private System.Windows.Forms.Label lblColores;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtColor3;
		private System.Windows.Forms.TextBox txtColor2;
		private System.Windows.Forms.GroupBox gbxDATOSpaises;
		private System.Windows.Forms.Label lblDColores;
		private System.Windows.Forms.Label lblDIdioma;
		private System.Windows.Forms.Label lblDPoblacion;
		private System.Windows.Forms.Label lblDNombre;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

