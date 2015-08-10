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
    public partial class frmConsultaMembresia : Form
    {
        /*
         * Programador: Kevin Cajbon
         * 
        */

        string sActualizarCodigo;
        public frmConsultaMembresia()
        {
            InitializeComponent();
            funActualizar();
        }

        void funCancelar() {
            txtActualizarTipo.Text = "";
            txtActualizarPorcentaje.Text = "";
            btnBuscar.Enabled = true;
            txtTipo.Enabled = true;
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
            string sTipo;
            string sPorcentaje;
            int iContador = 0;
            grdConsultaMembresia.Rows.Clear();

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT * FROM MEMBRESIA"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sCodigo = _reader.GetString(0);
                    sTipo = _reader.GetString(1);
                    sPorcentaje = _reader.GetString(2);
                    grdConsultaMembresia.Rows.Insert(iContador,sCodigo, sTipo, sPorcentaje);
                    sCodigo = "";
                    sTipo = "";
                    sPorcentaje = "";
                    iContador++;
                }
                grdConsultaMembresia.ClearSelection();

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
            string sPorcentaje;
            int iContador = 0;
            bool existe = false;
            grdConsultaMembresia.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtTipo.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                    "SELECT * FROM MEMBRESIA WHERE ctipomembresia = '{0}' ", txtTipo.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();

                    while (_reader.Read())
                    {
                        existe = true;
                        sCodigo = _reader.GetString(0);
                        sNombre = _reader.GetString(1);
                        sPorcentaje = _reader.GetString(2);
                        grdConsultaMembresia.Rows.Insert(iContador, sCodigo, sNombre, sPorcentaje);
                        sCodigo = "";
                        sNombre = "";
                        sPorcentaje = "";
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
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE MEMBRESIA SET ctipomembresia = '{0}', cporcentaje ='{1}' WHERE ncodmembresia = '{2}'",
                txtActualizarTipo.Text, txtActualizarPorcentaje.Text, sActualizarCodigo), clasConexion.funConexion());
                comando.ExecuteNonQuery();
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

        private void grdConsultaMembresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string sNombre;
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            grpActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = false;
            txtTipo.Clear();
            txtTipo.Enabled = false;
            DataGridViewRow fila = grdConsultaMembresia.CurrentRow;
            sActualizarCodigo = Convert.ToString(fila.Cells[0].Value);
            txtActualizarTipo.Text = Convert.ToString(fila.Cells[1].Value);
            txtActualizarPorcentaje.Text = Convert.ToString(fila.Cells[2].Value);
            //txtNombre.Text = sNombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM MEMBRESIA WHERE ncodmembresia = '{0}'",
                sActualizarCodigo), clasConexion.funConexion());
                comando.ExecuteNonQuery();
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
