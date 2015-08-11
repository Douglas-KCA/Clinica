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
    public partial class frmConsultaPacientes : Form
    {
        public frmConsultaPacientes()
        {
            InitializeComponent();
            funActualizar();
        }


        void funActualizar()
        {
            string sCodigo;
            string sNombre;
            string sApellido;
            string sDpi;
            string sDireccion;
            string sEmail;
            string sSexo;
            string sFecha;
            string sNit;
            string sReferencia;
            int iContador = 0;
            grdPaciente.Rows.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT persona.ncodpersona, persona.cdpipersona, persona.cnombrepersona, persona.capellidopersona, persona.cdireccionpersona, persona.cemailpersona, persona.csexopersona, persona.dfechanacpersona, persona.cnitpersona, paciente.crefpaciente from persona, paciente WHERE persona.ncodpersona = paciente.ncodpersona"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sDpi = mReader.GetString(1);
                    sNombre = mReader.GetString(2);
                    sApellido = mReader.GetString(3);
                    sDireccion = mReader.GetString(4);
                    sEmail = mReader.GetString(5);
                    sSexo = mReader.GetString(6);
                    sFecha = mReader.GetString(7);
                    sNit = mReader.GetString(8);
                    sReferencia = mReader.GetString(9);
                    grdPaciente.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sDireccion, sEmail, sSexo, sFecha, sNit, sReferencia);
                    sCodigo = "";
                    sDpi = "";
                    sNombre = "";
                    sApellido = "";
                    sDireccion = "";
                    sEmail = "";
                    sSexo = "";
                    sFecha = "";
                    sNit = "";
                    sReferencia = "";
                    iContador++;
                }

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
            string sApellido;
            string sDpi;
            string sDireccion;
            string sEmail;
            string sSexo;
            string sFecha;
            string sNit;
            string sReferencia;
            int iContador = 0;
            bool existe = false;
            grdPaciente.Rows.Clear();

            try
            {

                if ((String.IsNullOrEmpty(txtNombre.Text)) && (String.IsNullOrEmpty(txtDpi.Text)))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT persona.ncodpersona, persona.cdpipersona, persona.cnombrepersona, persona.capellidopersona, persona.cdireccionpersona, persona.cemailpersona, persona.csexopersona, persona.dfechanacpersona, persona.cnitpersona, paciente.crefpaciente from persona, paciente WHERE persona.ncodpersona = paciente.ncodpersona and persona.cnombrepersona = '{0}' and persona.cdpipersona = '{1}'", txtNombre.Text, txtDpi.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        existe = true;
                        sCodigo = mReader.GetString(0);
                        sDpi = mReader.GetString(1);
                        sNombre = mReader.GetString(2);
                        sApellido = mReader.GetString(3);
                        sDireccion = mReader.GetString(4);
                        sEmail = mReader.GetString(5);
                        sSexo = mReader.GetString(6);
                        sFecha = mReader.GetString(7);
                        sNit = mReader.GetString(8);
                        sReferencia = mReader.GetString(9);
                        grdPaciente.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sDireccion, sEmail, sSexo, sFecha, sNit, sReferencia);
                        sCodigo = "";
                        sDpi = "";
                        sNombre = "";
                        sApellido = "";
                        sDireccion = "";
                        sEmail = "";
                        sSexo = "";
                        sFecha = "";
                        sNit = "";
                        sReferencia = "";
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
    }
}
