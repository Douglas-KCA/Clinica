namespace Laboratorio
{
    partial class frmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicio));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscarCodigoCita = new System.Windows.Forms.Label();
            this.btnBuscarCodigoCita = new System.Windows.Forms.Button();
            this.btnBuscarNoSucursal = new System.Windows.Forms.Button();
            this.lblNoSucursal = new System.Windows.Forms.Label();
            this.txtNoSucursal = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigoTipoExamen = new System.Windows.Forms.Button();
            this.lblCodigoTipoExamen = new System.Windows.Forms.Label();
            this.txtCodigoTipoExamen = new System.Windows.Forms.TextBox();
            this.btnBuscarNoExpediente = new System.Windows.Forms.Button();
            this.lblNoExpediente = new System.Windows.Forms.Label();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCodigoFactura = new System.Windows.Forms.Button();
            this.lblCodigoFactura = new System.Windows.Forms.Label();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.btnCodigoEmpleado = new System.Windows.Forms.Button();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 29);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(133, 440);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 81);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblBuscarCodigoCita
            // 
            this.lblBuscarCodigoCita.AutoSize = true;
            this.lblBuscarCodigoCita.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCodigoCita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodigoCita.Location = new System.Drawing.Point(151, 72);
            this.lblBuscarCodigoCita.Name = "lblBuscarCodigoCita";
            this.lblBuscarCodigoCita.Size = new System.Drawing.Size(88, 19);
            this.lblBuscarCodigoCita.TabIndex = 15;
            this.lblBuscarCodigoCita.Text = "Codigo Cita:";
            // 
            // btnBuscarCodigoCita
            // 
            this.btnBuscarCodigoCita.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigoCita.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodigoCita.Image")));
            this.btnBuscarCodigoCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigoCita.Location = new System.Drawing.Point(304, 70);
            this.btnBuscarCodigoCita.Name = "btnBuscarCodigoCita";
            this.btnBuscarCodigoCita.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarCodigoCita.TabIndex = 16;
            this.btnBuscarCodigoCita.Text = "Buscar";
            this.btnBuscarCodigoCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigoCita.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNoSucursal
            // 
            this.btnBuscarNoSucursal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNoSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNoSucursal.Image")));
            this.btnBuscarNoSucursal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNoSucursal.Location = new System.Drawing.Point(570, 70);
            this.btnBuscarNoSucursal.Name = "btnBuscarNoSucursal";
            this.btnBuscarNoSucursal.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarNoSucursal.TabIndex = 19;
            this.btnBuscarNoSucursal.Text = "Buscar";
            this.btnBuscarNoSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNoSucursal.UseVisualStyleBackColor = true;
            // 
            // lblNoSucursal
            // 
            this.lblNoSucursal.AutoSize = true;
            this.lblNoSucursal.BackColor = System.Drawing.Color.Transparent;
            this.lblNoSucursal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSucursal.Location = new System.Drawing.Point(420, 72);
            this.lblNoSucursal.Name = "lblNoSucursal";
            this.lblNoSucursal.Size = new System.Drawing.Size(93, 19);
            this.lblNoSucursal.TabIndex = 18;
            this.lblNoSucursal.Text = "No. Sucursal:";
            // 
            // txtNoSucursal
            // 
            this.txtNoSucursal.Location = new System.Drawing.Point(423, 100);
            this.txtNoSucursal.Name = "txtNoSucursal";
            this.txtNoSucursal.Size = new System.Drawing.Size(141, 20);
            this.txtNoSucursal.TabIndex = 17;
            // 
            // btnBuscarCodigoTipoExamen
            // 
            this.btnBuscarCodigoTipoExamen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigoTipoExamen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodigoTipoExamen.Image")));
            this.btnBuscarCodigoTipoExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigoTipoExamen.Location = new System.Drawing.Point(302, 144);
            this.btnBuscarCodigoTipoExamen.Name = "btnBuscarCodigoTipoExamen";
            this.btnBuscarCodigoTipoExamen.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarCodigoTipoExamen.TabIndex = 22;
            this.btnBuscarCodigoTipoExamen.Text = "Buscar";
            this.btnBuscarCodigoTipoExamen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigoTipoExamen.UseVisualStyleBackColor = true;
            // 
            // lblCodigoTipoExamen
            // 
            this.lblCodigoTipoExamen.AutoSize = true;
            this.lblCodigoTipoExamen.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoTipoExamen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoTipoExamen.Location = new System.Drawing.Point(151, 144);
            this.lblCodigoTipoExamen.Name = "lblCodigoTipoExamen";
            this.lblCodigoTipoExamen.Size = new System.Drawing.Size(145, 19);
            this.lblCodigoTipoExamen.TabIndex = 21;
            this.lblCodigoTipoExamen.Text = "Codigo Tipo Examen:";
            // 
            // txtCodigoTipoExamen
            // 
            this.txtCodigoTipoExamen.Location = new System.Drawing.Point(155, 174);
            this.txtCodigoTipoExamen.Name = "txtCodigoTipoExamen";
            this.txtCodigoTipoExamen.Size = new System.Drawing.Size(141, 20);
            this.txtCodigoTipoExamen.TabIndex = 20;
            // 
            // btnBuscarNoExpediente
            // 
            this.btnBuscarNoExpediente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNoExpediente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNoExpediente.Image")));
            this.btnBuscarNoExpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarNoExpediente.Location = new System.Drawing.Point(571, 144);
            this.btnBuscarNoExpediente.Name = "btnBuscarNoExpediente";
            this.btnBuscarNoExpediente.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarNoExpediente.TabIndex = 25;
            this.btnBuscarNoExpediente.Text = "Buscar";
            this.btnBuscarNoExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNoExpediente.UseVisualStyleBackColor = true;
            // 
            // lblNoExpediente
            // 
            this.lblNoExpediente.AutoSize = true;
            this.lblNoExpediente.BackColor = System.Drawing.Color.Transparent;
            this.lblNoExpediente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExpediente.Location = new System.Drawing.Point(420, 144);
            this.lblNoExpediente.Name = "lblNoExpediente";
            this.lblNoExpediente.Size = new System.Drawing.Size(111, 19);
            this.lblNoExpediente.TabIndex = 24;
            this.lblNoExpediente.Text = "No. Expediente:";
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Location = new System.Drawing.Point(424, 174);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(141, 20);
            this.txtNoExpediente.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // btnBuscarCodigoFactura
            // 
            this.btnBuscarCodigoFactura.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigoFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCodigoFactura.Image")));
            this.btnBuscarCodigoFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCodigoFactura.Location = new System.Drawing.Point(571, 213);
            this.btnBuscarCodigoFactura.Name = "btnBuscarCodigoFactura";
            this.btnBuscarCodigoFactura.Size = new System.Drawing.Size(110, 50);
            this.btnBuscarCodigoFactura.TabIndex = 33;
            this.btnBuscarCodigoFactura.Text = "Buscar";
            this.btnBuscarCodigoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodigoFactura.UseVisualStyleBackColor = true;
            // 
            // lblCodigoFactura
            // 
            this.lblCodigoFactura.AutoSize = true;
            this.lblCodigoFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoFactura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFactura.Location = new System.Drawing.Point(420, 213);
            this.lblCodigoFactura.Name = "lblCodigoFactura";
            this.lblCodigoFactura.Size = new System.Drawing.Size(110, 19);
            this.lblCodigoFactura.TabIndex = 32;
            this.lblCodigoFactura.Text = "Codigo Factura:";
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Location = new System.Drawing.Point(424, 243);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(141, 20);
            this.txtCodigoFactura.TabIndex = 31;
            // 
            // btnCodigoEmpleado
            // 
            this.btnCodigoEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnCodigoEmpleado.Image")));
            this.btnCodigoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodigoEmpleado.Location = new System.Drawing.Point(302, 213);
            this.btnCodigoEmpleado.Name = "btnCodigoEmpleado";
            this.btnCodigoEmpleado.Size = new System.Drawing.Size(110, 50);
            this.btnCodigoEmpleado.TabIndex = 30;
            this.btnCodigoEmpleado.Text = "Buscar";
            this.btnCodigoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCodigoEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(151, 213);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(126, 19);
            this.lblCodigoEmpleado.TabIndex = 29;
            this.lblCodigoEmpleado.Text = "Codigo Empleado:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(155, 243);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(141, 20);
            this.txtCodigoEmpleado.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Servicios Agregados";
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(692, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarCodigoFactura);
            this.Controls.Add(this.lblCodigoFactura);
            this.Controls.Add(this.txtCodigoFactura);
            this.Controls.Add(this.btnCodigoEmpleado);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarNoExpediente);
            this.Controls.Add(this.lblNoExpediente);
            this.Controls.Add(this.txtNoExpediente);
            this.Controls.Add(this.btnBuscarCodigoTipoExamen);
            this.Controls.Add(this.lblCodigoTipoExamen);
            this.Controls.Add(this.txtCodigoTipoExamen);
            this.Controls.Add(this.btnBuscarNoSucursal);
            this.Controls.Add(this.lblNoSucursal);
            this.Controls.Add(this.txtNoSucursal);
            this.Controls.Add(this.btnBuscarCodigoCita);
            this.Controls.Add(this.lblBuscarCodigoCita);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscarCodigoCita;
        private System.Windows.Forms.Button btnBuscarCodigoCita;
        private System.Windows.Forms.Button btnBuscarNoSucursal;
        private System.Windows.Forms.Label lblNoSucursal;
        private System.Windows.Forms.TextBox txtNoSucursal;
        private System.Windows.Forms.Button btnBuscarCodigoTipoExamen;
        private System.Windows.Forms.Label lblCodigoTipoExamen;
        private System.Windows.Forms.TextBox txtCodigoTipoExamen;
        private System.Windows.Forms.Button btnBuscarNoExpediente;
        private System.Windows.Forms.Label lblNoExpediente;
        private System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscarCodigoFactura;
        private System.Windows.Forms.Label lblCodigoFactura;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Button btnCodigoEmpleado;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}