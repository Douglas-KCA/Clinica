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
    public partial class frmSeguro : Form
    {
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 07 de agosto
         * Fecha de Entrega: 09 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */

        string sCadena;
        public frmSeguro()
        {
            InitializeComponent();
            funBuscarAseguro();
            funBuscarTarifa();
        }

        void funBuscarTarifa()
        {
            string sCodigo;
            string sTarifa;
            string sDeducible;
            int iContador = 0;
            cmbTarifa.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodtarifa, nporcentajetarifa, ndeducible FROM TRTARIFASEGURO"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sTarifa = mReader.GetString(1);
                    sDeducible = mReader.GetString(2);
                    cmbTarifa.Items.Add(sCodigo + ". Tarifa: " + sTarifa + " Deducible: "+ sDeducible);
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
        
       
        void funBuscarAseguro()
        {
            string sCodigo;
            string sSeguro;
            int iContador = 0;
            cmbAseguradora.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM TRASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sSeguro = mReader.GetString(1);
                    cmbAseguradora.Items.Add(sCodigo + ". " + sSeguro);
                    sCodigo = "";
                    sSeguro = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void frmSeguro_Load(object sender, EventArgs e)
        {

        }

        string funCortador(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
               
            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return sCadena;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            


            try
            {
                string sCodAseguradora = "";
                string sCodigoAseguradora = "";
                string sCodTarifa = "";
                string sCodigoTarifa = "";
                sCodAseguradora = cmbAseguradora.SelectedItem.ToString();
                sCodigoAseguradora = funCortador(sCodAseguradora);
                sCodTarifa = cmbTarifa.SelectedItem.ToString();
                sCodigoTarifa = funCortador(sCodTarifa);
               
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into MRSEGURO (ncodtarifa, ncodaseguradora) values ('{0}','{1}')",
                        sCodigoTarifa,sCodigoAseguradora), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
               

            }
            catch
            {
                MessageBox.Show("Seleccione los Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funBuscarAseguro();
            funBuscarTarifa();
        }
    }
}
