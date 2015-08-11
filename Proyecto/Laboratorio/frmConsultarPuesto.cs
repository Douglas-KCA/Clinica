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
    /*---------------------------------------------------------------------------------------------------
     * Programador: Diego Taracena
     * Fecha de Astignacion: 01 de agosto
     * Fecha de Entrega: 02 de Agosto
     * -------------------------------------------------------------------------------------------------- 
     */
    public partial class frmConsultarPuesto : Form
    {
        string sCodigoTabla;
        public frmConsultarPuesto()
        {
            InitializeComponent();
            funActualizar();
        }
        /*-----------------------------------------------------------------------------------------------
         * Esta funcion hace una consulta y muestra todos los datos disponibles en el data grid view
         * ----------------------------------------------------------------------------------------------
         * */
        void funActualizar()
        {
            string sNumero;
            string sPuesto;
            int iContador = 0;
            grdPuesto.Rows.Clear();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ncodpuesto, ndescpuesto FROM PUESTO"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sNumero = _reader.GetString(0);
                    sPuesto = _reader.GetString(1);
                    grdPuesto.Rows.Insert(iContador, sNumero, sPuesto);
                    sNumero = "";
                    sPuesto = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /*------------------------------------------------------------------------------------------------------------------
         * Esta funcion toma los datos de los campos y muestra en el data grid view los resultados de la consulta
         * -----------------------------------------------------------------------------------------------------------------
         * */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sNumero;
            string sPuesto;
            int iContador = 0;
            bool existe = false;
            grdPuesto.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtPuesto.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT ncodpuesto, ndescpuesto FROM PUESTO WHERE ndescpuesto = '{0}' ", txtPuesto.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sNumero = _reader.GetString(0);
                        sPuesto = _reader.GetString(1);
                        grdPuesto.Rows.Insert(iContador, sNumero, sPuesto);
                        sNumero = "";
                        sPuesto = "";
                        iContador++;
                    }

                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }



            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPuesto.Clear();
            funActualizar();
        }

        private void grdPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodigo, sPuesto;
            DataGridViewRow fila = grdPuesto.CurrentRow;
            sCodigo = Convert.ToString(fila.Cells[0].Value);
            sPuesto = Convert.ToString(fila.Cells[1].Value);
            sCodigoTabla = sCodigo;
            txtPuesto.Text = sPuesto;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE PUESTO SET ndescpuesto ='{0}' WHERE ncodpuesto = '{1}'",
                    txtPuesto.Text, sCodigoTabla), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuesto.Clear();
                


            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Puesto WHERE ncodpuesto = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se elimino con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuesto.Clear();
                


            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
