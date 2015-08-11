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
/*---------------------------------------------------------------------------------------------------------------------------------
  Programador y Analista: Josue Revolorio
  * Fecha de asignacion: 07/08/2015
  * Fecha de entrega: 08/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmSucursal : Form
    {
        
        public frmSucursal()
        {
            InitializeComponent();
            funActualizar();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que actualiza los datos de la tabla con los de la BD
        ---------------------------------------------------------------------------------------------------------------------------------*/
        void funActualizar()
        {
            string sUbicacion;
            string sNombre;
            string sCodigo;
            int iContador = 0;
            grdSucursal.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodsucursal, cnombresucursal, cubicacion FROM SUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    sUbicacion = mReader.GetString(2);
                    grdSucursal.Rows.Insert(iContador, sCodigo, sNombre, sUbicacion);
                    sUbicacion = "";
                    sNombre = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que guarda los datos de la sucursal en la BD y las añade a la tabla en el form 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtUbicacion.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into SUCURSAL(cnombresucursal, cubicacion)  values ('{0}','{1}')",
                    txtNombre.Text, txtUbicacion.Text), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    txtNombre.Text = "";
                    txtUbicacion.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtUbicacion.Text = "";
        }
    }
}
