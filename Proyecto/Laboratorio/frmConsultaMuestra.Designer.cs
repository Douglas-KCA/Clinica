namespace Laboratorio
{
    partial class frmConsultaMuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMuestra));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpActualizar = new System.Windows.Forms.GroupBox();
            this.txtActualizarDescripcion = new System.Windows.Forms.TextBox();
            this.lblActualizarDescripcion = new System.Windows.Forms.Label();
            this.txtActualizarRequerimientos = new System.Windows.Forms.TextBox();
            this.lblActualizarRequerimientos = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grdConsultaMuestra = new System.Windows.Forms.DataGridView();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deducible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones.SuspendLayout();
            this.grpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnBuscar);
            this.pnlBotones.Controls.Add(this.btnActualizar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Location = new System.Drawing.Point(12, 29);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(133, 311);
            this.pnlBotones.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 164);
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
            this.btnBuscar.Location = new System.Drawing.Point(12, 19);
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
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(12, 89);
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
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpActualizar
            // 
            this.grpActualizar.Controls.Add(this.txtActualizarDescripcion);
            this.grpActualizar.Controls.Add(this.lblActualizarDescripcion);
            this.grpActualizar.Controls.Add(this.txtActualizarRequerimientos);
            this.grpActualizar.Controls.Add(this.lblActualizarRequerimientos);
            this.grpActualizar.Enabled = false;
            this.grpActualizar.Location = new System.Drawing.Point(157, 61);
            this.grpActualizar.Name = "grpActualizar";
            this.grpActualizar.Size = new System.Drawing.Size(506, 115);
            this.grpActualizar.TabIndex = 38;
            this.grpActualizar.TabStop = false;
            this.grpActualizar.Text = "Actualizar";
            // 
            // txtActualizarDescripcion
            // 
            this.txtActualizarDescripcion.Location = new System.Drawing.Point(123, 71);
            this.txtActualizarDescripcion.Multiline = true;
            this.txtActualizarDescripcion.Name = "txtActualizarDescripcion";
            this.txtActualizarDescripcion.Size = new System.Drawing.Size(377, 38);
            this.txtActualizarDescripcion.TabIndex = 35;
            // 
            // lblActualizarDescripcion
            // 
            this.lblActualizarDescripcion.AutoSize = true;
            this.lblActualizarDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarDescripcion.Location = new System.Drawing.Point(6, 72);
            this.lblActualizarDescripcion.Name = "lblActualizarDescripcion";
            this.lblActualizarDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblActualizarDescripcion.TabIndex = 34;
            this.lblActualizarDescripcion.Text = "Descripcion:";
            // 
            // txtActualizarRequerimientos
            // 
            this.txtActualizarRequerimientos.Location = new System.Drawing.Point(123, 17);
            this.txtActualizarRequerimientos.Multiline = true;
            this.txtActualizarRequerimientos.Name = "txtActualizarRequerimientos";
            this.txtActualizarRequerimientos.Size = new System.Drawing.Size(377, 38);
            this.txtActualizarRequerimientos.TabIndex = 33;
            // 
            // lblActualizarRequerimientos
            // 
            this.lblActualizarRequerimientos.AutoSize = true;
            this.lblActualizarRequerimientos.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarRequerimientos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarRequerimientos.Location = new System.Drawing.Point(6, 19);
            this.lblActualizarRequerimientos.Name = "lblActualizarRequerimientos";
            this.lblActualizarRequerimientos.Size = new System.Drawing.Size(115, 19);
            this.lblActualizarRequerimientos.TabIndex = 32;
            this.lblActualizarRequerimientos.Text = "Requerimientos:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(248, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(415, 20);
            this.txtDescripcion.TabIndex = 37;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(153, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 19);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Descripcion:";
            // 
            // grdConsultaMuestra
            // 
            this.grdConsultaMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarifa,
            this.Deducible,
            this.Porcentaje});
            this.grdConsultaMuestra.Location = new System.Drawing.Point(157, 182);
            this.grdConsultaMuestra.Name = "grdConsultaMuestra";
            this.grdConsultaMuestra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaMuestra.Size = new System.Drawing.Size(506, 153);
            this.grdConsultaMuestra.TabIndex = 35;
            this.grdConsultaMuestra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaMuestra_CellContentClick);
            // 
            // Tarifa
            // 
            this.Tarifa.HeaderText = "No.";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // Deducible
            // 
            this.Deducible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Deducible.HeaderText = "Requerimientos";
            this.Deducible.Name = "Deducible";
            this.Deducible.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Descipcion";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // frmConsultaMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.grpActualizar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.grdConsultaMuestra);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaMuestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Muestra";
            this.pnlBotones.ResumeLayout(false);
            this.grpActualizar.ResumeLayout(false);
            this.grpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpActualizar;
        private System.Windows.Forms.TextBox txtActualizarDescripcion;
        private System.Windows.Forms.Label lblActualizarDescripcion;
        private System.Windows.Forms.TextBox txtActualizarRequerimientos;
        private System.Windows.Forms.Label lblActualizarRequerimientos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView grdConsultaMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deducible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}