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
    public partial class frmConsultaAseguradora : Form
    {
        /*
         * Programador: Dylan Corado
         * 
        */
        string sCodigoTabla;
        public frmConsultaAseguradora()
        {
            InitializeComponent();
            funActualizar();
        }

        void funCancelar()
        {
            txtActualizarNombre.Text = "";
            btnBuscar.Enabled = true;
            txtNombre.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
            //grdConsultaMembresia.LostFocus=0;
        }

        void funActualizar()
        {

            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdConsultarAseguradora.Rows.Clear();

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM TRASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sCodigo = _reader.GetString(0);
                    sNombre = _reader.GetString(1);
                    grdConsultarAseguradora.Rows.Insert(iContador, sCodigo, sNombre);
                    sCodigo = "";
                    sNombre = "";
                    iContador++;
                }
                grdConsultarAseguradora.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            bool existe = false;
            grdConsultarAseguradora.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT ncodaseguradora, cempresaseguro FROM TRASEGURADORA WHERE cempresaseguro = '{0}' ", txtNombre.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sCodigo = _reader.GetString(0);
                        sNombre = _reader.GetString(1);
                        grdConsultarAseguradora.Rows.Insert(iContador, sCodigo, sNombre);
                        sCodigo = "";
                        sNombre = "";
                        iContador++;
                    }

                    if (existe == false)
                    {
                        MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    btnCancelar.Enabled = true;
                }



            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                    MySqlCommand comando = new MySqlCommand(string.Format("UPDATE TRASEGURADORA SET cempresaseguro = '{0}' WHERE ncodaseguradora = '{1}'",
                    txtActualizarNombre.Text, sCodigoTabla), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    funCancelar();
                    funActualizar();
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
        }

        private void grdConsultaAseguradora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM TRASEGURADORA WHERE ncodaseguradora = '{0}'",
                sCodigoTabla), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                funCancelar();
                funActualizar();
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void grdConsultarAseguradora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            txtNombre.Clear();
            txtNombre.Enabled = false;

            string sNombre;
            DataGridViewRow fila = grdConsultarAseguradora.CurrentRow;
            sCodigoTabla = Convert.ToString(fila.Cells[0].Value);
            sNombre = Convert.ToString(fila.Cells[1].Value);
            txtActualizarNombre.Text = sNombre;
        }
    }
}
