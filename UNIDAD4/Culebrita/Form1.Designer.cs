namespace Culebrita
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
            this.pbTablero = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.Ciclo = new System.Windows.Forms.Timer(this.components);
            this.lblSnake = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTablero
            // 
            this.pbTablero.Location = new System.Drawing.Point(12, 12);
            this.pbTablero.Name = "pbTablero";
            this.pbTablero.Size = new System.Drawing.Size(730, 330);
            this.pbTablero.TabIndex = 0;
            this.pbTablero.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(123, 377);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(122, 31);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "Puntaje:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(284, 377);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(30, 31);
            this.lblPuntos.TabIndex = 2;
            this.lblPuntos.Text = "0";
            // 
            // Ciclo
            // 
            this.Ciclo.Enabled = true;
            this.Ciclo.Tick += new System.EventHandler(this.Ciclo_Tick);
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnake.Location = new System.Drawing.Point(434, 368);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(123, 40);
            this.lblSnake.TabIndex = 3;
            this.lblSnake.Text = "Snake";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Culebrita.Properties.Resources.rattlesnake_159135_1280;
            this.pictureBox1.Location = new System.Drawing.Point(572, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSnake);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pbTablero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTablero;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer Ciclo;
        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

