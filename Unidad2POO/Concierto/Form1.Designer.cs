namespace Concierto
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
            this.lblAsistentes = new System.Windows.Forms.Label();
            this.cmbEntradas = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblBebes = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl3raEdad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmbAsistentes = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsistentes
            // 
            this.lblAsistentes.AutoSize = true;
            this.lblAsistentes.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistentes.Location = new System.Drawing.Point(55, 44);
            this.lblAsistentes.Name = "lblAsistentes";
            this.lblAsistentes.Size = new System.Drawing.Size(90, 18);
            this.lblAsistentes.TabIndex = 1;
            this.lblAsistentes.Text = "Asistentes:";
            // 
            // cmbEntradas
            // 
            this.cmbEntradas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntradas.FormattingEnabled = true;
            this.cmbEntradas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbEntradas.Location = new System.Drawing.Point(219, 113);
            this.cmbEntradas.Name = "cmbEntradas";
            this.cmbEntradas.Size = new System.Drawing.Size(54, 21);
            this.cmbEntradas.TabIndex = 2;
            this.cmbEntradas.SelectedIndexChanged += new System.EventHandler(this.cmbEntradas_SelectedIndexChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(188, 177);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(85, 29);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Contabilizar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(210, 421);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(63, 28);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.Location = new System.Drawing.Point(129, 112);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(83, 18);
            this.lblEntradas.TabIndex = 5;
            this.lblEntradas.Text = "Entradas:";
            // 
            // lblBebes
            // 
            this.lblBebes.AutoSize = true;
            this.lblBebes.Location = new System.Drawing.Point(24, 228);
            this.lblBebes.Name = "lblBebes";
            this.lblBebes.Size = new System.Drawing.Size(37, 13);
            this.lblBebes.TabIndex = 6;
            this.lblBebes.Text = "Bebes";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(24, 284);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(34, 13);
            this.lblNiños.TabIndex = 7;
            this.lblNiños.Text = "Niños";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adultos";
            // 
            // lbl3raEdad
            // 
            this.lbl3raEdad.AutoSize = true;
            this.lbl3raEdad.Location = new System.Drawing.Point(24, 410);
            this.lbl3raEdad.Name = "lbl3raEdad";
            this.lbl3raEdad.Size = new System.Drawing.Size(72, 13);
            this.lbl3raEdad.TabIndex = 9;
            this.lbl3raEdad.Text = "Tercera Edad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 348);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 407);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 13;
            // 
            // cmbAsistentes
            // 
            this.cmbAsistentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistentes.FormattingEnabled = true;
            this.cmbAsistentes.Items.AddRange(new object[] {
            "Bebes",
            "Niños",
            "Adultos",
            "Tercera Edad"});
            this.cmbAsistentes.Location = new System.Drawing.Point(152, 40);
            this.cmbAsistentes.Name = "cmbAsistentes";
            this.cmbAsistentes.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistentes.TabIndex = 14;
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
            this.ClientSize = new System.Drawing.Size(300, 476);
            this.Controls.Add(this.cmbAsistentes);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl3raEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.lblBebes);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.cmbEntradas);
            this.Controls.Add(this.lblAsistentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAsistentes;
        private System.Windows.Forms.ComboBox cmbEntradas;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblBebes;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl3raEdad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cmbAsistentes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

