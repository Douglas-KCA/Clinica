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

    /*------------------------------------------------------------------------------------------------------
     * Programador y analista: Diego Taracena
     * Fecha de asignacion: 7-8-2015
     * Fecha de Entrega: 10-8-2015
     * -------------------------------------------------------------------------------------------------------
     * */
{
    public partial class frmPaciente : Form
    {
        string sCadena;
        string sCodPersona;
        public frmPaciente()
        {
            InitializeComponent();
            funBuscarAseguro();
            funBuscarMembresia();
        }

        
        void funBuscarAseguro()
        {
            string sCodigo;
            string sAseguradora;
            string sTarifa;
            string sDeducible;
            cmbSeguro.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT mrseguro.ncodseguro as codSeguro, traseguradora.cempresaseguro as Aseguradora,trtarifaseguro.nporcentajetarifa as Tarifa ,trtarifaseguro.ndeducible as Deducible  from mrseguro, traseguradora, trtarifaseguro where mrseguro.ncodtarifa = trtarifaseguro.ncodtarifa and mrseguro.ncodaseguradora = traseguradora.ncodaseguradora"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sAseguradora = mReader.GetString(1);
                    sTarifa = mReader.GetString(2);
                    sDeducible = mReader.GetString(3);
                    cmbSeguro.Items.Add(sCodigo + ". " + sAseguradora +" Tarifa: "+sTarifa+" Deducible: "+ sDeducible);
                    sCodigo = "";
                    sAseguradora = "";
                    sTarifa = "";
                    sDeducible = "";
           
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void funBuscarMembresia()
        {
            string sCodigo;
            string sMembrecia;
            cmbMembresia.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodmembresia, ctipomembresia FROM MEMBRESIA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sMembrecia = mReader.GetString(1);
                    cmbMembresia.Items.Add(sCodigo + ".  Tipo:" + sMembrecia);
                    sCodigo = "";
                    sMembrecia = "";
               
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        string funCortador(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sSexo;
            
            string sFecha = dtpNacimiento.Text;
           

            try
            {
                if (rbMasculino.Checked == true)
                {
                    sSexo = "Masculino";
                }
                else
                {
                    sSexo = "Femenino";
                }

                if ((String.IsNullOrEmpty(txtDpi.Text)) && (String.IsNullOrEmpty(txtNombre.Text)) && (String.IsNullOrEmpty(txtApellido.Text)) && (String.IsNullOrEmpty(txtDireccion.Text)) && (String.IsNullOrEmpty(txtEmail.Text)) && (String.IsNullOrEmpty(txtNit.Text)) && (String.IsNullOrEmpty(txtReferencia.Text)))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(string.Format("Insert into PERSONA (cdireccionpersona, cemailpersona, cnombrepersona, capellidopersona, cdpipersona, dfechanacpersona, csexopersona, cnitpersona) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                        txtDireccion.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text, txtDpi.Text, sFecha, sSexo, txtNit.Text ), clasConexion.funConexion());
                    mComando.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDireccion.Clear();
                    txtEmail.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    
                    txtNit.Clear();
                    sSexo = "";
                    sFecha = "";
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //consulta de codigo
            
            try
            {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT ncodpersona FROM PERSONA WHERE cdpipersona = '{0}' ", txtDpi.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodPersona = mReader.GetString(0);
                    }             
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //ingreso en paciente
            string sCodSeguro;
            sCodSeguro = funCortador(cmbSeguro.SelectedItem.ToString());
            string sCodMembresia;
            sCodMembresia = funCortador(cmbMembresia.SelectedItem.ToString());
            try
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Insert into PACIENTE (crefpaciente, ncodpersona, ncodseguro, ncodmembresia) values ('{0}', '{1}', '{2}', '{3}')",
                        txtReferencia.Text, sCodPersona, sCodSeguro, sCodMembresia), clasConexion.funConexion());
                    comando.ExecuteNonQuery(); 
                    MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReferencia.Clear();
                    txtDpi.Clear();
               

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDpi.Clear();
            txtEmail.Clear();
            txtNit.Clear();
            txtNombre.Clear();
            txtReferencia.Clear();
        }
    }
}
