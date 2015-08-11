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
    /*
     * Programador y Analista: Dylan Corado
     * Fecha de Asignacion: 03 de Agosto
     * Fecha de Entrega: 05 de Agosto  
    */
    public partial class frmAseguradora : Form
    {
        public frmAseguradora()
        {
            InitializeComponent();
            funActualizar();
        }

        //Funcion que actualiza DataGridView para mostrar datos insertados
        void funActualizar()
        {

            string sCodigo;
            string sNombre;
            int iContador = 0;
            grdAseguradora.Rows.Clear();

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ncodaseguradora, cempresaseguro FROM TRASEGURADORA"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sCodigo = _reader.GetString(0);
                    sNombre = _reader.GetString(1);
                    grdAseguradora.Rows.Insert(iContador, sCodigo, sNombre);
                    sCodigo = "";
                    sNombre = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into TRASEGURADORA (cempresaseguro) values ('{0}')",
                    txtNombre.Text), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
