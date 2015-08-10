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
     *   
    */ 
    public partial class frmMuestra : Form
    {
        public frmMuestra()
        {
            InitializeComponent();
        }

        void limpiar() {
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
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into MUESTRA(crequerimientos, cdescmuestra)  values ('{0}','{1}')",
                    txtRequerimientos.Text, txtDescripcionMuestra), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }
    }
}
