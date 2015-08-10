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
   Programador: Josue Revolorio
   Analista: Kevin Cajbon 
---------------------------------------------------------------------------------------------------------------------------------*/

    public partial class frmConsultaSucursal : Form
    {
        public frmConsultaSucursal()
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
            int iContador = 0;
            grdSucursal.Rows.Clear();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT cnombresucursal, cubicacion FROM SUCURSAL"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sNombre = _reader.GetString(0);
                    sUbicacion = _reader.GetString(1);
                    grdSucursal.Rows.Insert(iContador, sNombre, sUbicacion);
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
          Funcion que filtra los datos del grid a partir de un parametro de busqueda
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sUbicacion;
            string sNombre;
            int iContador = 0;
            bool existe = false;
            grdSucursal.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT cnombresucursal, cubicacion FROM SUCURSAL WHERE cnombresucursal = '{0}' ", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sNombre = _reader.GetString(0);
                        sUbicacion = _reader.GetString(1);
                        grdSucursal.Rows.Insert(iContador, sNombre, sUbicacion);
                        sUbicacion = "";
                        sNombre = "";
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
            txtNombre.Text = "";
            funActualizar();
        }
    }
}
