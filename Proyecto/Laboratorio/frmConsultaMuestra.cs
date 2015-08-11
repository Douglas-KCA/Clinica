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
    public partial class frmConsultaMuestra : Form
    {
        /*
         * Programador: Kevin Cajbon
         * Fecha de Astignacion: 01 de agosto
         * Fecha de Entrega: 03 de Agosto
         *   
        */
        string sActualizarCodigo;
        public frmConsultaMuestra()
        {
            InitializeComponent();
            funActualizar();
        }

        void funCancelar()
        {
            txtActualizarRequerimientos.Clear();
            txtActualizarDescripcion.Clear();
            txtDescripcion.Clear();
            btnBuscar.Enabled = true;
            txtDescripcion.Enabled = true;
            grpActualizar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            funActualizar();
        }

        void funActualizar()
        {

            string sCodigo;
            string sRequerimientos;
            string sDescMuestra;
            int iContador = 0;
            grdConsultaMuestra.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT * FROM MUESTRA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sRequerimientos = mReader.GetString(1);
                    sDescMuestra = mReader.GetString(2);
                    grdConsultaMuestra.Rows.Insert(iContador, sCodigo, sRequerimientos, sDescMuestra);
                    sCodigo = "";
                    sRequerimientos = "";
                    sDescMuestra = "";
                    iContador++;
                }
                grdConsultaMuestra.ClearSelection();

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sRequerimientos;
            string sDescMuestra;
            int iContador = 0;
            bool existe = false;
            grdConsultaMuestra.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT * FROM MUESTRA WHERE cdescmuestra = '{0}' ", txtDescripcion.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sRequerimientos = mReader.GetString(1);
                        sDescMuestra = mReader.GetString(2);
                        grdConsultaMuestra.Rows.Insert(iContador, sCodigo, sRequerimientos, sDescMuestra);
                        sCodigo = "";
                        sRequerimientos = "";
                        sDescMuestra = "";
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

        private void grdConsultaMuestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            txtDescripcion.Clear();
            txtDescripcion.Enabled = false;
            DataGridViewRow fila = grdConsultaMuestra.CurrentRow;
            sActualizarCodigo = Convert.ToString(fila.Cells[0].Value);
            txtActualizarRequerimientos.Text = Convert.ToString(fila.Cells[1].Value);
            txtActualizarDescripcion.Text = Convert.ToString(fila.Cells[2].Value);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE MUESTRA SET crequerimientos = '{0}', cdescmuestra ='{1}' WHERE ncodmuestra = '{2}'",
                txtActualizarRequerimientos.Text, txtActualizarDescripcion.Text, sActualizarCodigo), clasConexion.funConexion());
                mComando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("DELETE FROM MUESTRA WHERE ncodmuestra = '{0}'",
                sActualizarCodigo), clasConexion.funConexion());
                mComando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Dato eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funCancelar();
                funActualizar();
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
