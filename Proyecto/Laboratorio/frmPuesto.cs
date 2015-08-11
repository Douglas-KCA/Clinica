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
        /*---------------------------------------------------------------------------------------------------
         * Programador: Diego Taracena
         * Fecha de Astignacion: 05 de agosto
         * Fecha de Entrega: 06 de Agosto
         * -------------------------------------------------------------------------------------------------- 
        */
    public partial class frmPuesto : Form
    {
        public frmPuesto()
        {

            InitializeComponent();
            funActualizar();
        }
      //--- Esta funcion actualiza los datos y los llena en el data grid view --------------------------------------
        void funActualizar()
        {

            string sCodigo;
            string sPuesto;
            int iContador = 0;
            grdPuesto.Rows.Clear();

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT ncodpuesto, ndescpuesto FROM PUESTO"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read())
                {
                    sCodigo = _reader.GetString(0);
                    sPuesto = _reader.GetString(1);
                    grdPuesto.Rows.Insert(iContador, sCodigo, sPuesto);
                    sCodigo = "";
                    sPuesto = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    //-- Esta funcion toma los valores de los campos y los inserta en su respectiva tabla -----------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPuesto.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand(string.Format("Insert into PUESTO (ndescpuesto) values ('{0}')",
                        txtPuesto.Text), clasConexion.funConexion());
                    comando.ExecuteNonQuery();
                    funActualizar();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPuesto.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
