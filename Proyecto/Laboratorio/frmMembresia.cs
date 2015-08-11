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
    /*
     * Programador: Kevin Cajbon
     * Fecha de Astignacion: 01 de agosto
     * Fecha de Entrega: 02 de Agosto
     *   
    */
    public partial class frmMembresia : Form
    {
        public frmMembresia()
        {
            InitializeComponent();
        }

        void funLimpiar() {
            txtPorcentaje.Clear();
            txtTipoMembresia.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((String.IsNullOrEmpty(txtTipoMembresia.Text)) && ((String.IsNullOrEmpty(txtPorcentaje.Text))))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MEMBRESIA(ctipomembresia, cporcentaje)  values ('{0}','{1}')",
                    txtTipoMembresia.Text, txtPorcentaje.Text), clasConexion.funConexion());
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
