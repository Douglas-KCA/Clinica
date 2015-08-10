namespace Laboratorio
{
    partial class frmMuestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuestra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblRequerimientos = new System.Windows.Forms.Label();
            this.txtRequerimientos = new System.Windows.Forms.TextBox();
            this.lblDescripcionMuestra = new System.Windows.Forms.Label();
            this.txtDescripcionMuestra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 311);
            this.panel1.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 123);
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblRequerimientos
            // 
            this.lblRequerimientos.AutoSize = true;
            this.lblRequerimientos.BackColor = System.Drawing.Color.Transparent;
            this.lblRequerimientos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequerimientos.Location = new System.Drawing.Point(163, 29);
            this.lblRequerimientos.Name = "lblRequerimientos";
            this.lblRequerimientos.Size = new System.Drawing.Size(115, 19);
            this.lblRequerimientos.TabIndex = 31;
            this.lblRequerimientos.Text = "Requerimientos:";
            // 
            // txtRequerimientos
            // 
            this.txtRequerimientos.Location = new System.Drawing.Point(167, 55);
            this.txtRequerimientos.Multiline = true;
            this.txtRequerimientos.Name = "txtRequerimientos";
            this.txtRequerimientos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRequerimientos.Size = new System.Drawing.Size(460, 112);
            this.txtRequerimientos.TabIndex = 32;
            // 
            // lblDescripcionMuestra
            // 
            this.lblDescripcionMuestra.AutoSize = true;
            this.lblDescripcionMuestra.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMuestra.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcionMuestra.Location = new System.Drawing.Point(163, 180);
            this.lblDescripcionMuestra.Name = "lblDescripcionMuestra";
            this.lblDescripcionMuestra.Size = new System.Drawing.Size(147, 19);
            this.lblDescripcionMuestra.TabIndex = 33;
            this.lblDescripcionMuestra.Text = "Descripcion Muestra:";
            // 
            // txtDescripcionMuestra
            // 
            this.txtDescripcionMuestra.Location = new System.Drawing.Point(167, 206);
            this.txtDescripcionMuestra.Multiline = true;
            this.txtDescripcionMuestra.Name = "txtDescripcionMuestra";
            this.txtDescripcionMuestra.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDescripcionMuestra.Size = new System.Drawing.Size(460, 112);
            this.txtDescripcionMuestra.TabIndex = 34;
            // 
            // frmMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.txtDescripcionMuestra);
            this.Controls.Add(this.lblDescripcionMuestra);
            this.Controls.Add(this.txtRequerimientos);
            this.Controls.Add(this.lblRequerimientos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMuestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblRequerimientos;
        private System.Windows.Forms.TextBox txtRequerimientos;
        private System.Windows.Forms.Label lblDescripcionMuestra;
        private System.Windows.Forms.TextBox txtDescripcionMuestra;

    }
}