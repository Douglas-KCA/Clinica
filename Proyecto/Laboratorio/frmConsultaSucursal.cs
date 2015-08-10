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
          Funcion que pobla el grid con los datos de la BD
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
        /*private void CellBeginEdit(object sender,DataGridViewCellCancelEventArgs e)
        {
            String sNombre = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[0].Value + "";
            String sUbicacion = grdSucursal.Rows[grdSucursal.CurrentCell.RowIndex].Cells[1].Value + "";
            txtNombre.Text = sNombre + sUbicacion;
        }*/
        
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
            int i;
            for (i = 0; i <= grdSucursal.RowCount -1; i++)
            {
                String sNombre = grdSucursal.Rows[i].Cells[0].Value + "";
                String sUbicacion = grdSucursal.Rows[i].Cells[1].Value + "";
                try
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE SUCURSAL SET cubicacion = '{0}', cnombresucursal = '{1}' WHERE ncodsucursal = '{2}'", sUbicacion, sNombre, i+1), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            funActualizar();
        }
        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que Elimina la fila seleccionada
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
