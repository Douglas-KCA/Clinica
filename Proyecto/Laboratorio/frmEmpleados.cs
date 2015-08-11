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
    public partial class frmEmpleados : Form
    {
        /*
         * Programador y Analista: Manuel Chuquiej
         * Fecha de Asignacion: 01 de Agosto
         * Fecha de Entrega: 04 de Agosto
        */
        string sSexo;
        public frmEmpleados()
        {
            InitializeComponent();
            funPuesto();
        }

        void funPuesto()
        {
            string sCodigo;
            string sNombre;
            cmbPuesto.Items.Clear();
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpuesto, ndescpuesto FROM PUESTO", txtNombre.Text), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigo = mReader.GetString(0);
                sNombre = mReader.GetString(1);
                cmbPuesto.Items.Add(sCodigo+". "+sNombre);
                sCodigo = "";
                sNombre = "";
            }

        }

        void funObtenerCodPersona()
        {
            string sCodigoPersona;
            MySqlCommand mComando = new MySqlCommand(String.Format(
                   "SELECT ncodpersona FROM PERSONA WHERE cdpipersona= '{0}'", txtDpi.Text), clasConexion.funConexion());
            MySqlDataReader mReader = mComando.ExecuteReader();

            while (mReader.Read())
            {
                sCodigoPersona = mReader.GetString(0);
                funInsertarTablaEmpleado(sCodigoPersona);
            }

        }

        void funInsertarTablaEmpleado(string sCodigoPersona)
        {
            MessageBox.Show("Codigo Persona: "+sCodigoPersona);




            txtApellido.Clear();
            txtDireccion.Clear();
            txtDpi.Clear();
            txtEmail.Clear();
            txtNit.Clear();
            txtNombre.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtDpi.Text) && String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtApellido.Text) && String.IsNullOrEmpty(txtDireccion.Text) && String.IsNullOrEmpty(txtEmail.Text) && String.IsNullOrEmpty(txtNit.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if(rbMasculino.Checked == true)
                    {
                        sSexo = "Masculino";
                    }else if(rbFemenino.Checked==true)
                    {
                        sSexo = "Femenino";
                    }
                    MessageBox.Show(txtDireccion.Text + txtEmail.Text + txtNombre.Text + txtApellido.Text + txtDpi.Text + dtpNacimiento.Text + sSexo + txtNit.Text);
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into PERSONA (cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    txtDireccion.Text,txtEmail.Text,txtNombre.Text,txtApellido.Text,txtDpi.Text,dtpNacimiento.Text,sSexo,txtNit.Text), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funObtenerCodPersona();
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
