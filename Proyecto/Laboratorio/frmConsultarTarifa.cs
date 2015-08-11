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
    

    public partial class frmConsultarTarifa : Form
    {
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 03 de agosto
         * Fecha de Entrega: 05 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */

        string sCodigoTabla;
        public frmConsultarTarifa()
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
            string sCodigo;
            string sTarifa;
            string sDeducible;
            int iContador = 0;
            grdTarifa.Rows.Clear();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ncodtarifa, nporcentajetarifa, ndeducible FROM TRTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sCodigo = _reader.GetString(0);
                    sTarifa = _reader.GetString(1);
                    sDeducible = _reader.GetString(2);
                    grdTarifa.Rows.Insert(iContador, sCodigo, sTarifa, sDeducible);
                    sCodigo = "";
                    sTarifa = "";
                    sDeducible = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       /*----------------------------------------------------------------------------------------------------------------------
        * Esta funcion realiza una consulta con los datos que se encuentren en los campos
        * ---------------------------------------------------------------------------------------------------------------------
        * */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sTarifa;
            string sDeducible;
            int iContador = 0;
            bool existe = false;
            grdTarifa.Rows.Clear();

            try
            {

                if ((String.IsNullOrEmpty(txtTarifa.Text)) && (String.IsNullOrEmpty(txtDeducible.Text)))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT ncodtarifa, nporcentajetarifa, ndeducible FROM TRTARIFASEGURO WHERE nporcentajetarifa = '{0}' or ndeducible = '{1}' ", txtTarifa.Text, txtDeducible.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sCodigo = _reader.GetString(0);
                        sTarifa = _reader.GetString(1);
                        sDeducible = _reader.GetString(2);
                        grdTarifa.Rows.Insert(iContador, sCodigo, sTarifa, sDeducible);
                        sCodigo = "";
                        sTarifa = "";
                        sDeducible = "";
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
        /*----------------------------------------------------------------------------------------------------
         * Esta funcion regresa el form a su forma original
         * ---------------------------------------------------------------------------------------------------
         * */

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDeducible.Clear();
            txtTarifa.Clear();
            funActualizar();
        }

        private void grdTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodigo, sTarifa, sDeducible;
            DataGridViewRow fila = grdTarifa.CurrentRow;
            sCodigo = Convert.ToString(fila.Cells[0].Value);
            sTarifa = Convert.ToString(fila.Cells[1].Value);
            sDeducible = Convert.ToString(fila.Cells[2].Value);
            sCodigoTabla = sCodigo;
            txtTarifa.Text = sTarifa;
            txtDeducible.Text = sDeducible;
            


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TRTARIFASEGURO SET nporcentajetarifa ='{0}', ndeducible = '{1}' WHERE ncodtarifa = '{2}'",
                        txtTarifa.Text, txtDeducible.Text, sCodigoTabla), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTarifa.Clear();
                    txtDeducible.Clear();


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

                MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM TRTARIFASEGURO WHERE ncodtarifa = '{0}'",
                    sCodigoTabla), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se elimino con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTarifa.Clear();
                txtDeducible.Clear();


            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
