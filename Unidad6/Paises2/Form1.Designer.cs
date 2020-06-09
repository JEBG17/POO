namespace Paises2
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
			this.gbxRegistro = new System.Windows.Forms.GroupBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblRegistro = new System.Windows.Forms.Label();
			this.gbxResultado = new System.Windows.Forms.GroupBox();
			this.lblRNombre = new System.Windows.Forms.Label();
			this.lblRcolor = new System.Windows.Forms.Label();
			this.lblRIdioma = new System.Windows.Forms.Label();
			this.lblRPoblacion = new System.Windows.Forms.Label();
			this.gbxBuscar = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.gbxPaises = new System.Windows.Forms.GroupBox();
			this.gbxBnderas = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtColor3 = new System.Windows.Forms.TextBox();
			this.txtColor2 = new System.Windows.Forms.TextBox();
			this.txtColor1 = new System.Windows.Forms.TextBox();
			this.lblColores = new System.Windows.Forms.Label();
			this.txtIdioma = new System.Windows.Forms.TextBox();
			this.lblIdioma = new System.Windows.Forms.Label();
			this.txtPoblacion = new System.Windows.Forms.TextBox();
			this.lblPoblacion = new System.Windows.Forms.Label();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.lblNPaises = new System.Windows.Forms.Label();
			this.gbxRegistro.SuspendLayout();
			this.gbxResultado.SuspendLayout();
			this.gbxBuscar.SuspendLayout();
			this.gbxPaises.SuspendLayout();
			this.gbxBnderas.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxRegistro
			// 
			this.gbxRegistro.Controls.Add(this.txtCantidad);
			this.gbxRegistro.Controls.Add(this.btnAceptar);
			this.gbxRegistro.Controls.Add(this.lblRegistro);
			this.gbxRegistro.Location = new System.Drawing.Point(21, 12);
			this.gbxRegistro.Name = "gbxRegistro";
			this.gbxRegistro.Size = new System.Drawing.Size(351, 60);
			this.gbxRegistro.TabIndex = 10;
			this.gbxRegistro.TabStop = false;
			this.gbxRegistro.Text = "Registro";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(121, 17);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(76, 20);
			this.txtCantidad.TabIndex = 5;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(203, 17);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(64, 23);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblRegistro
			// 
			this.lblRegistro.AutoSize = true;
			this.lblRegistro.Location = new System.Drawing.Point(15, 20);
			this.lblRegistro.Name = "lblRegistro";
			this.lblRegistro.Size = new System.Drawing.Size(97, 26);
			this.lblRegistro.TabIndex = 4;
			this.lblRegistro.Text = "Cantidad de paises\r\n a registrar:";
			// 
			// gbxResultado
			// 
			this.gbxResultado.Controls.Add(this.lblRNombre);
			this.gbxResultado.Controls.Add(this.lblRcolor);
			this.gbxResultado.Controls.Add(this.lblRIdioma);
			this.gbxResultado.Controls.Add(this.lblRPoblacion);
			this.gbxResultado.Location = new System.Drawing.Point(389, 96);
			this.gbxResultado.Name = "gbxResultado";
			this.gbxResultado.Size = new System.Drawing.Size(399, 313);
			this.gbxResultado.TabIndex = 11;
			this.gbxResultado.TabStop = false;
			this.gbxResultado.Text = "Resultado de busqueda ";
			// 
			// lblRNombre
			// 
			this.lblRNombre.AutoSize = true;
			this.lblRNombre.Location = new System.Drawing.Point(28, 35);
			this.lblRNombre.Name = "lblRNombre";
			this.lblRNombre.Size = new System.Drawing.Size(0, 13);
			this.lblRNombre.TabIndex = 5;
			// 
			// lblRcolor
			// 
			this.lblRcolor.AutoSize = true;
			this.lblRcolor.Location = new System.Drawing.Point(28, 157);
			this.lblRcolor.Name = "lblRcolor";
			this.lblRcolor.Size = new System.Drawing.Size(0, 13);
			this.lblRcolor.TabIndex = 3;
			// 
			// lblRIdioma
			// 
			this.lblRIdioma.AutoSize = true;
			this.lblRIdioma.Location = new System.Drawing.Point(28, 119);
			this.lblRIdioma.Name = "lblRIdioma";
			this.lblRIdioma.Size = new System.Drawing.Size(0, 13);
			this.lblRIdioma.TabIndex = 2;
			// 
			// lblRPoblacion
			// 
			this.lblRPoblacion.AutoSize = true;
			this.lblRPoblacion.Location = new System.Drawing.Point(28, 76);
			this.lblRPoblacion.Name = "lblRPoblacion";
			this.lblRPoblacion.Size = new System.Drawing.Size(0, 13);
			this.lblRPoblacion.TabIndex = 1;
			// 
			// gbxBuscar
			// 
			this.gbxBuscar.Controls.Add(this.btnBuscar);
			this.gbxBuscar.Controls.Add(this.txtBuscar);
			this.gbxBuscar.Controls.Add(this.lblBuscar);
			this.gbxBuscar.Location = new System.Drawing.Point(389, 12);
			this.gbxBuscar.Name = "gbxBuscar";
			this.gbxBuscar.Size = new System.Drawing.Size(399, 60);
			this.gbxBuscar.TabIndex = 9;
			this.gbxBuscar.TabStop = false;
			this.gbxBuscar.Text = "Buscar país ";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(297, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 7;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(118, 20);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(173, 20);
			this.txtBuscar.TabIndex = 3;
			// 
			// lblBuscar
			// 
			this.lblBuscar.AutoSize = true;
			this.lblBuscar.Location = new System.Drawing.Point(12, 23);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(86, 13);
			this.lblBuscar.TabIndex = 2;
			this.lblBuscar.Text = "Nombre del pais:";
			// 
			// gbxPaises
			// 
			this.gbxPaises.Controls.Add(this.gbxBnderas);
			this.gbxPaises.Controls.Add(this.txtIdioma);
			this.gbxPaises.Controls.Add(this.lblIdioma);
			this.gbxPaises.Controls.Add(this.txtPoblacion);
			this.gbxPaises.Controls.Add(this.lblPoblacion);
			this.gbxPaises.Controls.Add(this.txtPais);
			this.gbxPaises.Controls.Add(this.lblNPaises);
			this.gbxPaises.Location = new System.Drawing.Point(12, 91);
			this.gbxPaises.Name = "gbxPaises";
			this.gbxPaises.Size = new System.Drawing.Size(360, 347);
			this.gbxPaises.TabIndex = 8;
			this.gbxPaises.TabStop = false;
			this.gbxPaises.Text = "Datos de los paises ";
			// 
			// gbxBnderas
			// 
			this.gbxBnderas.Controls.Add(this.btnGuardar);
			this.gbxBnderas.Controls.Add(this.txtColor3);
			this.gbxBnderas.Controls.Add(this.txtColor2);
			this.gbxBnderas.Controls.Add(this.txtColor1);
			this.gbxBnderas.Controls.Add(this.lblColores);
			this.gbxBnderas.Location = new System.Drawing.Point(0, 162);
			this.gbxBnderas.Name = "gbxBnderas";
			this.gbxBnderas.Size = new System.Drawing.Size(360, 193);
			this.gbxBnderas.TabIndex = 6;
			this.gbxBnderas.TabStop = false;
			this.gbxBnderas.Text = "Bandera del pais ";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(246, 156);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtColor3
			// 
			this.txtColor3.Location = new System.Drawing.Point(142, 104);
			this.txtColor3.Name = "txtColor3";
			this.txtColor3.Size = new System.Drawing.Size(173, 20);
			this.txtColor3.TabIndex = 5;
			// 
			// txtColor2
			// 
			this.txtColor2.Location = new System.Drawing.Point(142, 68);
			this.txtColor2.Name = "txtColor2";
			this.txtColor2.Size = new System.Drawing.Size(173, 20);
			this.txtColor2.TabIndex = 4;
			// 
			// txtColor1
			// 
			this.txtColor1.Location = new System.Drawing.Point(142, 34);
			this.txtColor1.Name = "txtColor1";
			this.txtColor1.Size = new System.Drawing.Size(173, 20);
			this.txtColor1.TabIndex = 3;
			// 
			// lblColores
			// 
			this.lblColores.AutoSize = true;
			this.lblColores.Location = new System.Drawing.Point(6, 71);
			this.lblColores.Name = "lblColores";
			this.lblColores.Size = new System.Drawing.Size(123, 26);
			this.lblColores.TabIndex = 2;
			this.lblColores.Text = "Los 3 colores principales\r\n      de tu bandera ";
			// 
			// txtIdioma
			// 
			this.txtIdioma.Location = new System.Drawing.Point(112, 117);
			this.txtIdioma.Name = "txtIdioma";
			this.txtIdioma.Size = new System.Drawing.Size(173, 20);
			this.txtIdioma.TabIndex = 5;
			// 
			// lblIdioma
			// 
			this.lblIdioma.AutoSize = true;
			this.lblIdioma.Location = new System.Drawing.Point(6, 120);
			this.lblIdioma.Name = "lblIdioma";
			this.lblIdioma.Size = new System.Drawing.Size(96, 13);
			this.lblIdioma.TabIndex = 4;
			this.lblIdioma.Text = "Idioma predominte:";
			// 
			// txtPoblacion
			// 
			this.txtPoblacion.Location = new System.Drawing.Point(112, 74);
			this.txtPoblacion.Name = "txtPoblacion";
			this.txtPoblacion.Size = new System.Drawing.Size(173, 20);
			this.txtPoblacion.TabIndex = 3;
			// 
			// lblPoblacion
			// 
			this.lblPoblacion.AutoSize = true;
			this.lblPoblacion.Location = new System.Drawing.Point(6, 77);
			this.lblPoblacion.Name = "lblPoblacion";
			this.lblPoblacion.Size = new System.Drawing.Size(80, 13);
			this.lblPoblacion.TabIndex = 2;
			this.lblPoblacion.Text = "Poblacion total:";
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(112, 33);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(173, 20);
			this.txtPais.TabIndex = 1;
			// 
			// lblNPaises
			// 
			this.lblNPaises.AutoSize = true;
			this.lblNPaises.Location = new System.Drawing.Point(6, 36);
			this.lblNPaises.Name = "lblNPaises";
			this.lblNPaises.Size = new System.Drawing.Size(86, 13);
			this.lblNPaises.TabIndex = 0;
			this.lblNPaises.Text = "Nombre del pais:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbxRegistro);
			this.Controls.Add(this.gbxResultado);
			this.Controls.Add(this.gbxBuscar);
			this.Controls.Add(this.gbxPaises);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxRegistro.ResumeLayout(false);
			this.gbxRegistro.PerformLayout();
			this.gbxResultado.ResumeLayout(false);
			this.gbxResultado.PerformLayout();
			this.gbxBuscar.ResumeLayout(false);
			this.gbxBuscar.PerformLayout();
			this.gbxPaises.ResumeLayout(false);
			this.gbxPaises.PerformLayout();
			this.gbxBnderas.ResumeLayout(false);
			this.gbxBnderas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxRegistro;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblRegistro;
		private System.Windows.Forms.GroupBox gbxResultado;
		private System.Windows.Forms.Label lblRNombre;
		private System.Windows.Forms.Label lblRcolor;
		private System.Windows.Forms.Label lblRIdioma;
		private System.Windows.Forms.Label lblRPoblacion;
		private System.Windows.Forms.GroupBox gbxBuscar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.GroupBox gbxPaises;
		private System.Windows.Forms.GroupBox gbxBnderas;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtColor3;
		private System.Windows.Forms.TextBox txtColor2;
		private System.Windows.Forms.TextBox txtColor1;
		private System.Windows.Forms.Label lblColores;
		private System.Windows.Forms.TextBox txtIdioma;
		private System.Windows.Forms.Label lblIdioma;
		private System.Windows.Forms.TextBox txtPoblacion;
		private System.Windows.Forms.Label lblPoblacion;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.Label lblNPaises;
	}
}

