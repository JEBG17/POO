namespace EmpleadosRestaurante
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoTrabajador = new System.Windows.Forms.Label();
            this.cmbTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSueldoSemanal = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gbxMesero = new System.Windows.Forms.GroupBox();
            this.txtPropinas = new System.Windows.Forms.TextBox();
            this.lblPropinas = new System.Windows.Forms.Label();
            this.gpbCajero = new System.Windows.Forms.GroupBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.lblCaja = new System.Windows.Forms.Label();
            this.gpbRepartidor = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblReparto = new System.Windows.Forms.Label();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.lblSueldoMesero = new System.Windows.Forms.Label();
            this.gpbSueldos = new System.Windows.Forms.GroupBox();
            this.lblSueldoReparto = new System.Windows.Forms.Label();
            this.lblSueldoCajero = new System.Windows.Forms.Label();
            this.lblPedidoEntregado = new System.Windows.Forms.Label();
            this.txtPedidos = new System.Windows.Forms.TextBox();
            this.gbxDatos.SuspendLayout();
            this.gbxMesero.SuspendLayout();
            this.gpbCajero.SuspendLayout();
            this.gpbRepartidor.SuspendLayout();
            this.gpbSueldos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipoTrabajador
            // 
            this.lblTipoTrabajador.AutoSize = true;
            this.lblTipoTrabajador.Location = new System.Drawing.Point(30, 87);
            this.lblTipoTrabajador.Name = "lblTipoTrabajador";
            this.lblTipoTrabajador.Size = new System.Drawing.Size(93, 13);
            this.lblTipoTrabajador.TabIndex = 2;
            this.lblTipoTrabajador.Text = "Tipo de trabajador";
            // 
            // cmbTipoTrabajo
            // 
            this.cmbTipoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTrabajo.FormattingEnabled = true;
            this.cmbTipoTrabajo.Items.AddRange(new object[] {
            "Mesero",
            "Cajero",
            "Repartidor"});
            this.cmbTipoTrabajo.Location = new System.Drawing.Point(146, 84);
            this.cmbTipoTrabajo.Name = "cmbTipoTrabajo";
            this.cmbTipoTrabajo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTrabajo.TabIndex = 3;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtDias);
            this.gbxDatos.Controls.Add(this.lblDias);
            this.gbxDatos.Controls.Add(this.txtSueldo);
            this.gbxDatos.Controls.Add(this.lblFechaNac);
            this.gbxDatos.Controls.Add(this.lblSueldoSemanal);
            this.gbxDatos.Controls.Add(this.dtpFechaNacimiento);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.cmbTipoTrabajo);
            this.gbxDatos.Controls.Add(this.lblTipoTrabajador);
            this.gbxDatos.Location = new System.Drawing.Point(12, 12);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(292, 251);
            this.gbxDatos.TabIndex = 5;
            this.gbxDatos.TabStop = false;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(146, 178);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 7;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(30, 172);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(97, 26);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "Dias de la semana \r\ntrabajado";
            this.lblDias.Click += new System.EventHandler(this.lblDias_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(118, 217);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 7;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(30, 132);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblSueldoSemanal
            // 
            this.lblSueldoSemanal.AutoSize = true;
            this.lblSueldoSemanal.Location = new System.Drawing.Point(30, 220);
            this.lblSueldoSemanal.Name = "lblSueldoSemanal";
            this.lblSueldoSemanal.Size = new System.Drawing.Size(82, 13);
            this.lblSueldoSemanal.TabIndex = 6;
            this.lblSueldoSemanal.Text = "Sueldo semanal";
            this.lblSueldoSemanal.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(146, 126);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // gbxMesero
            // 
            this.gbxMesero.Controls.Add(this.txtPropinas);
            this.gbxMesero.Controls.Add(this.lblPropinas);
            this.gbxMesero.Location = new System.Drawing.Point(12, 269);
            this.gbxMesero.Name = "gbxMesero";
            this.gbxMesero.Size = new System.Drawing.Size(292, 70);
            this.gbxMesero.TabIndex = 7;
            this.gbxMesero.TabStop = false;
            this.gbxMesero.Text = "Mesero";
            // 
            // txtPropinas
            // 
            this.txtPropinas.Location = new System.Drawing.Point(105, 31);
            this.txtPropinas.Name = "txtPropinas";
            this.txtPropinas.Size = new System.Drawing.Size(100, 20);
            this.txtPropinas.TabIndex = 9;
            // 
            // lblPropinas
            // 
            this.lblPropinas.AutoSize = true;
            this.lblPropinas.Location = new System.Drawing.Point(30, 34);
            this.lblPropinas.Name = "lblPropinas";
            this.lblPropinas.Size = new System.Drawing.Size(51, 13);
            this.lblPropinas.TabIndex = 8;
            this.lblPropinas.Text = "Propinas ";
            // 
            // gpbCajero
            // 
            this.gpbCajero.Controls.Add(this.cmbCaja);
            this.gpbCajero.Controls.Add(this.lblCaja);
            this.gpbCajero.Location = new System.Drawing.Point(12, 345);
            this.gpbCajero.Name = "gpbCajero";
            this.gpbCajero.Size = new System.Drawing.Size(292, 86);
            this.gpbCajero.TabIndex = 8;
            this.gpbCajero.TabStop = false;
            this.gpbCajero.Text = "Cajero";
            // 
            // cmbCaja
            // 
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCaja.Location = new System.Drawing.Point(105, 34);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(121, 21);
            this.cmbCaja.TabIndex = 1;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Location = new System.Drawing.Point(30, 37);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(71, 13);
            this.lblCaja.TabIndex = 0;
            this.lblCaja.Text = "Caja Numero:";
            // 
            // gpbRepartidor
            // 
            this.gpbRepartidor.Controls.Add(this.txtPedidos);
            this.gpbRepartidor.Controls.Add(this.lblPedidoEntregado);
            this.gpbRepartidor.Controls.Add(this.comboBox1);
            this.gpbRepartidor.Controls.Add(this.lblReparto);
            this.gpbRepartidor.Location = new System.Drawing.Point(12, 437);
            this.gpbRepartidor.Name = "gpbRepartidor";
            this.gpbRepartidor.Size = new System.Drawing.Size(296, 109);
            this.gpbRepartidor.TabIndex = 9;
            this.gpbRepartidor.TabStop = false;
            this.gpbRepartidor.Text = "Repartidor";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Zona 1",
            "Zona 2"});
            this.comboBox1.Location = new System.Drawing.Point(118, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.Location = new System.Drawing.Point(30, 32);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(83, 13);
            this.lblReparto.TabIndex = 0;
            this.lblReparto.Text = "Zona de reparto";
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(314, 523);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(92, 31);
            this.btnSueldo.TabIndex = 10;
            this.btnSueldo.Text = "Calcular sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // lblSueldoMesero
            // 
            this.lblSueldoMesero.AutoSize = true;
            this.lblSueldoMesero.Location = new System.Drawing.Point(65, 49);
            this.lblSueldoMesero.Name = "lblSueldoMesero";
            this.lblSueldoMesero.Size = new System.Drawing.Size(0, 13);
            this.lblSueldoMesero.TabIndex = 11;
            // 
            // gpbSueldos
            // 
            this.gpbSueldos.Controls.Add(this.lblSueldoReparto);
            this.gpbSueldos.Controls.Add(this.lblSueldoCajero);
            this.gpbSueldos.Controls.Add(this.lblSueldoMesero);
            this.gpbSueldos.Location = new System.Drawing.Point(379, 12);
            this.gpbSueldos.Name = "gpbSueldos";
            this.gpbSueldos.Size = new System.Drawing.Size(328, 483);
            this.gpbSueldos.TabIndex = 12;
            this.gpbSueldos.TabStop = false;
            this.gpbSueldos.Text = "Sueldo correspondiente ";
            // 
            // lblSueldoReparto
            // 
            this.lblSueldoReparto.AutoSize = true;
            this.lblSueldoReparto.Location = new System.Drawing.Point(68, 361);
            this.lblSueldoReparto.Name = "lblSueldoReparto";
            this.lblSueldoReparto.Size = new System.Drawing.Size(0, 13);
            this.lblSueldoReparto.TabIndex = 13;
            // 
            // lblSueldoCajero
            // 
            this.lblSueldoCajero.AutoSize = true;
            this.lblSueldoCajero.Location = new System.Drawing.Point(65, 214);
            this.lblSueldoCajero.Name = "lblSueldoCajero";
            this.lblSueldoCajero.Size = new System.Drawing.Size(0, 13);
            this.lblSueldoCajero.TabIndex = 12;
            // 
            // lblPedidoEntregado
            // 
            this.lblPedidoEntregado.AutoSize = true;
            this.lblPedidoEntregado.Location = new System.Drawing.Point(30, 73);
            this.lblPedidoEntregado.Name = "lblPedidoEntregado";
            this.lblPedidoEntregado.Size = new System.Drawing.Size(101, 13);
            this.lblPedidoEntregado.TabIndex = 2;
            this.lblPedidoEntregado.Text = "Pedidos entregados";
            // 
            // txtPedidos
            // 
            this.txtPedidos.Location = new System.Drawing.Point(146, 73);
            this.txtPedidos.Name = "txtPedidos";
            this.txtPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtPedidos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 558);
            this.Controls.Add(this.gpbSueldos);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.gpbRepartidor);
            this.Controls.Add(this.gpbCajero);
            this.Controls.Add(this.gbxMesero);
            this.Controls.Add(this.gbxDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxMesero.ResumeLayout(false);
            this.gbxMesero.PerformLayout();
            this.gpbCajero.ResumeLayout(false);
            this.gpbCajero.PerformLayout();
            this.gpbRepartidor.ResumeLayout(false);
            this.gpbRepartidor.PerformLayout();
            this.gpbSueldos.ResumeLayout(false);
            this.gpbSueldos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoTrabajador;
        private System.Windows.Forms.ComboBox cmbTipoTrabajo;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblSueldoSemanal;
        private System.Windows.Forms.GroupBox gbxMesero;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtPropinas;
        private System.Windows.Forms.Label lblPropinas;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox gpbCajero;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.GroupBox gpbRepartidor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblReparto;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Label lblSueldoMesero;
        private System.Windows.Forms.GroupBox gpbSueldos;
        private System.Windows.Forms.Label lblSueldoReparto;
        private System.Windows.Forms.Label lblSueldoCajero;
        private System.Windows.Forms.TextBox txtPedidos;
        private System.Windows.Forms.Label lblPedidoEntregado;
    }
}

