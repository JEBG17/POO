namespace CatalogoProgramas
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
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(204, 29);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Examinar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnAbrir
			// 
			this.btnAbrir.Location = new System.Drawing.Point(204, 67);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(75, 23);
			this.btnAbrir.TabIndex = 2;
			this.btnAbrir.Text = "Abrir";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(205, 105);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(12, 51);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(156, 20);
			this.txtDireccion.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 149);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAbrir);
			this.Controls.Add(this.btnBuscar);
			this.Name = "Form1";
			this.Text = "Programas ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnAbrir;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtDireccion;
	}
}

