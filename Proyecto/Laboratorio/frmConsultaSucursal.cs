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
 * Fecha de asignacion: 03/08/2015
 * Fecha de entrega: 05/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmConsultaSucursal : Form
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> master
//<<<<<<< HEAD
        //String sNombreEditar;
        //String sUbicacionEditar;
//=======
<<<<<<< HEAD
=======
=======

        //String sNombreEditar;
        //String sUbicacionEditar;

>>>>>>> master
>>>>>>> master
        public frmConsultaSucursal()
        {
            InitializeComponent();
            funActualizar();
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> master
//>>>>>>> master

=======
>>>>>>> master
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los valores de la fila seleccionada en el grid para mostrarlos en los campos de texto de edicion
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void grdSucursal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtActualizarNombre.Text = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[1].Value + "";
            txtActualizarUbicacion.Text = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[2].Value + "";

        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que pobla el grid con los datos de la BD
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
                    grdSucursal.Rows.Insert(iContador,sCodigo, sNombre, sUbicacion);
                    sUbicacion = "";
                    sNombre = "";
                    sCodigo = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que filtra el grid a partir del parametro que se indica en el textbox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sUbicacion;
            string sNombre;
            string sCodigo;
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
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodsucursal, cnombresucursal, cubicacion FROM SUCURSAL WHERE cnombresucursal = '{0}' ", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sNombre = mReader.GetString(1);
                        sUbicacion = mReader.GetString(2);
                        grdSucursal.Rows.Insert(iContador, sCodigo, sNombre, sUbicacion);
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
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que limpia los textbox o combobox
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            funActualizar();
        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que toma los datos del grid y los actualiza en la base de datos en caso exista un cambio
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE SUCURSAL SET cnombresucursal = '{0}', cubicacion = '{1}'  WHERE ncodsucursal = '{2}'",
                txtActualizarNombre.Text,txtActualizarUbicacion.Text, grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                funActualizar();
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Elimina la fila seleccionada
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM SUCURSAL WHERE ncodsucursal = '{0}'",
                grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[0].Value + ""), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funActualizar();
                txtActualizarNombre.Text = txtActualizarUbicacion.Text = "";
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
