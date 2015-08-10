namespace Laboratorio
{
    partial class frmConsultaCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCita));
            this.grdCita = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCita = new System.Windows.Forms.TextBox();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.lblActualizarPaciente = new System.Windows.Forms.Label();
            this.lblActualizarSucursal = new System.Windows.Forms.Label();
            this.lblActualizarHora = new System.Windows.Forms.Label();
            this.lblActualizarFecha = new System.Windows.Forms.Label();
            this.cmbActualizarSucursal = new System.Windows.Forms.ComboBox();
            this.cmbActualizarPaciente = new System.Windows.Forms.ComboBox();
            this.dtpActualizarCitas = new System.Windows.Forms.DateTimePicker();
            this.cmbActualizarHora = new System.Windows.Forms.ComboBox();
            this.cmbActualizarMinutos = new System.Windows.Forms.ComboBox();
            this.lblDosPuntos = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCita
            // 
            this.grdCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nombreSucursal,
            this.ubicacionSucursal,
            this.Fecha,
            this.Hora});
            this.grdCita.Location = new System.Drawing.Point(165, 183);
            this.grdCita.Name = "grdCita";
            this.grdCita.Size = new System.Drawing.Size(607, 221);
            this.grdCita.TabIndex = 18;
            this.grdCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCita_CellEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 424);
            this.panel1.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(12, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 50);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 138);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 50);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(161, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(39, 19);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Cita:";
            // 
            // txtCita
            // 
            this.txtCita.Location = new System.Drawing.Point(211, 29);
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(561, 20);
            this.txtCita.TabIndex = 31;
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.cmbActualizarHora);
            this.grpActualizar.Controls.Add(this.dtpActualizarCitas);
            this.grpActualizar.Controls.Add(this.cmbActualizarMinutos);
            this.grpActualizar.Controls.Add(this.lblDosPuntos);
            this.grpActualizar.Controls.Add(this.cmbActualizarPaciente);
            this.grpActualizar.Controls.Add(this.cmbActualizarSucursal);
            this.grpActualizar.Controls.Add(this.lblActualizarHora);
            this.grpActualizar.Controls.Add(this.lblActualizarFecha);
            this.grpActualizar.Controls.Add(this.lblActualizarPaciente);
            this.grpActualizar.Controls.Add(this.lblActualizarSucursal);
            this.grpActualizar.Location = new System.Drawing.Point(166, 55);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(606, 107);
            this.grpActualizar.TabIndex = 38;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // lblActualizarPaciente
            // 
            this.lblActualizarPaciente.AutoSize = true;
            this.lblActualizarPaciente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarPaciente.Location = new System.Drawing.Point(294, 26);
            this.lblActualizarPaciente.Name = "lblActualizarPaciente";
            this.lblActualizarPaciente.Size = new System.Drawing.Size(69, 19);
            this.lblActualizarPaciente.TabIndex = 3;
            this.lblActualizarPaciente.Text = "Paciente:";
            // 
            // lblActualizarSucursal
            // 
            this.lblActualizarSucursal.AutoSize = true;
            this.lblActualizarSucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarSucursal.Location = new System.Drawing.Point(6, 24);
            this.lblActualizarSucursal.Name = "lblActualizarSucursal";
            this.lblActualizarSucursal.Size = new System.Drawing.Size(67, 19);
            this.lblActualizarSucursal.TabIndex = 1;
            this.lblActualizarSucursal.Text = "Sucursal:";
            // 
            // lblActualizarHora
            // 
            this.lblActualizarHora.AutoSize = true;
            this.lblActualizarHora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarHora.Location = new System.Drawing.Point(294, 66);
            this.lblActualizarHora.Name = "lblActualizarHora";
            this.lblActualizarHora.Size = new System.Drawing.Size(44, 19);
            this.lblActualizarHora.TabIndex = 5;
            this.lblActualizarHora.Text = "Hora:";
            // 
            // lblActualizarFecha
            // 
            this.lblActualizarFecha.AutoSize = true;
            this.lblActualizarFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarFecha.Location = new System.Drawing.Point(6, 64);
            this.lblActualizarFecha.Name = "lblActualizarFecha";
            this.lblActualizarFecha.Size = new System.Drawing.Size(51, 19);
            this.lblActualizarFecha.TabIndex = 4;
            this.lblActualizarFecha.Text = "Fecha:";
            // 
            // cmbActualizarSucursal
            // 
            this.cmbActualizarSucursal.FormattingEnabled = true;
            this.cmbActualizarSucursal.Location = new System.Drawing.Point(79, 24);
            this.cmbActualizarSucursal.Name = "cmbActualizarSucursal";
            this.cmbActualizarSucursal.Size = new System.Drawing.Size(170, 21);
            this.cmbActualizarSucursal.TabIndex = 6;
            // 
            // cmbActualizarPaciente
            // 
            this.cmbActualizarPaciente.FormattingEnabled = true;
            this.cmbActualizarPaciente.Location = new System.Drawing.Point(377, 25);
            this.cmbActualizarPaciente.Name = "cmbActualizarPaciente";
            this.cmbActualizarPaciente.Size = new System.Drawing.Size(170, 21);
            this.cmbActualizarPaciente.TabIndex = 7;
            // 
            // dtpActualizarCitas
            // 
            this.dtpActualizarCitas.CustomFormat = "yyyy-MM-dd";
            this.dtpActualizarCitas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualizarCitas.Location = new System.Drawing.Point(79, 65);
            this.dtpActualizarCitas.Name = "dtpActualizarCitas";
            this.dtpActualizarCitas.Size = new System.Drawing.Size(170, 20);
            this.dtpActualizarCitas.TabIndex = 29;
            // 
            // cmbActualizarHora
            // 
            this.cmbActualizarHora.FormattingEnabled = true;
            this.cmbActualizarHora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbActualizarHora.Location = new System.Drawing.Point(378, 63);
            this.cmbActualizarHora.Name = "cmbActualizarHora";
            this.cmbActualizarHora.Size = new System.Drawing.Size(46, 21);
            this.cmbActualizarHora.TabIndex = 41;
            // 
            // cmbActualizarMinutos
            // 
            this.cmbActualizarMinutos.FormattingEnabled = true;
            this.cmbActualizarMinutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbActualizarMinutos.Location = new System.Drawing.Point(453, 64);
            this.cmbActualizarMinutos.Name = "cmbActualizarMinutos";
            this.cmbActualizarMinutos.Size = new System.Drawing.Size(46, 21);
            this.cmbActualizarMinutos.TabIndex = 40;
            // 
            // lblDosPuntos
            // 
            this.lblDosPuntos.AutoSize = true;
            this.lblDosPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblDosPuntos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosPuntos.Location = new System.Drawing.Point(432, 60);
            this.lblDosPuntos.Name = "lblDosPuntos";
            this.lblDosPuntos.Size = new System.Drawing.Size(15, 23);
            this.lblDosPuntos.TabIndex = 39;
            this.lblDosPuntos.Text = ":";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.HeaderText = "Sucursal";
            this.nombreSucursal.Name = "nombreSucursal";
            // 
            // ubicacionSucursal
            // 
            this.ubicacionSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacionSucursal.HeaderText = "Paciente";
            this.ubicacionSucursal.Name = "ubicacionSucursal";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // frmConsultaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.txtCita);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grdCita);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Citas";
            ((System.ComponentModel.ISupportInitialize)(this.grdCita)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCita;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.ComboBox cmbActualizarPaciente;
        private System.Windows.Forms.ComboBox cmbActualizarSucursal;
        private System.Windows.Forms.Label lblActualizarHora;
        private System.Windows.Forms.Label lblActualizarFecha;
        private System.Windows.Forms.Label lblActualizarPaciente;
        private System.Windows.Forms.Label lblActualizarSucursal;
        private System.Windows.Forms.DateTimePicker dtpActualizarCitas;
        private System.Windows.Forms.ComboBox cmbActualizarHora;
        private System.Windows.Forms.ComboBox cmbActualizarMinutos;
        private System.Windows.Forms.Label lblDosPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}