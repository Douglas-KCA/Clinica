using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{ 
    public partial class frmMuestra : Form
    {
        /*
         * Programador: Kevin Cajbon
         * Fecha de Astignacion: 01 de agosto
         * Fecha de Entrega: 03 de Agosto
         *   
        */

        public frmMuestra()
        {
            InitializeComponent();
        }

        void funLimpiar() {
            txtRequerimientos.Clear();
            txtDescripcionMuestra.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if((String.IsNullOrEmpty(txtRequerimientos.Text)) && ((String.IsNullOrEmpty(txtDescripcionMuestra.Text))))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }else{
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MUESTRA(crequerimientos, cdescmuestra)  values ('{0}','{1}')",
                    txtRequerimientos.Text, txtDescripcionMuestra.Text), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funLimpiar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funLimpiar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }
    }
}
