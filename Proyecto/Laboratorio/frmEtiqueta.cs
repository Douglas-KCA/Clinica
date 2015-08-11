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
    public partial class frmEtiqueta : Form
    {
        /*
         * Programador: Kevin Cajbon
         * Fecha de Astignacion: 07 de agosto
         * Fecha de Entrega: 08 de Agosto
         *   
        */
        string sCadena;
        public frmEtiqueta()
        {
            InitializeComponent();
            funLlenarMuestra();
            funLlenarPaciente();
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

        void funDatosEtiqueta() {
            //string sCodMuestra = "";
            //string sCodigoMuestra = "";
            //string sCodPaciente = "";
            //string sCodigoPaciente = "";
            lblTipoMuestra.Text = cmbCodMuestra.SelectedItem.ToString();
            //sCodMuestra = funCortador(sCodigoMuestra);
            lblInfoPaciente.Text = cmbCodPaciente.SelectedItem.ToString();
            //sCodigoPaciente = funCortador(sCodPaciente);
            btnImprimir.Enabled = true;
            btnGuardar.Enabled = false;
        }

        void funLlenarMuestra() {
            string sCodigo;
            string sDescripcionMuestra;            
            int iContador = 0;
            cmbCodMuestra.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT ncodmuestra, cdescmuestra FROM MUESTRA"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sDescripcionMuestra = mReader.GetString(1);                    
                    cmbCodMuestra.Items.Add(sCodigo + ". " + sDescripcionMuestra);
                    sCodigo = "";
                    sDescripcionMuestra = "";                    
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void funLlenarPaciente()
        {
            string sCodigo;
            string sNombre;
            int iContador = 0;
            cmbCodPaciente.Items.Clear();
            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT paciente.ncodpaciente, persona.cnombrepersona FROM paciente, persona WHERE paciente.ncodpersona=persona.ncodpersona"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    cmbCodPaciente.Items.Add(sCodigo + ". " + sNombre);
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
                string sCodMuestra = "";
                string sCodigoMuestra = "";
                string sCodPaciente = "";
                string sCodigoPaciente = "";
                sCodigoMuestra = cmbCodMuestra.SelectedItem.ToString();
                sCodMuestra = funCortador(sCodigoMuestra);
                sCodPaciente = cmbCodPaciente.SelectedItem.ToString();
                sCodigoPaciente = funCortador(sCodPaciente);

                MySqlCommand mComando = new MySqlCommand(string.Format("Insert into ETIQUETA (ncodmuestra, ncodpaciente) values ('{0}','{1}')",
                    sCodigoMuestra, sCodigoPaciente), clasConexion.funConexion());
                mComando.ExecuteNonQuery();
                MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funDatosEtiqueta();
            }
            catch
            {
                MessageBox.Show("Seleccione los Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se imprime la Etiqueta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGuardar.Enabled = true;
            btnImprimir.Enabled = false;
        }
    }
}
