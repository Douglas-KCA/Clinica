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
    public partial class frmConsultaEmpleados : Form
    {
        string sCodigoUp;
        string sDireccionUp;
        string sEmailUp;
        string sNombreUp;
        string sApellidoUp;
        string sDpiUp;
        string sFechaUp;
        string sSexoUp;
        string sNitUp;
        string sPuestoUp;
        public frmConsultaEmpleados()
        {
            InitializeComponent();
            funActualizar();
        }

        void funActualizar()
        {
            
            string sDireccion;
            string sEmail;
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sPuesto;
            string sCodigo;

            int iContador = 0;
            grdConsultarEmpleados.Rows.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT persona.ncodpersona, cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM PERSONA,PUESTO,EMPLEADO WHERE PUESTO.ncodpuesto=EMPLEADO.ncodpuesto"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sDireccion = mReader.GetString(1);
                    sEmail = mReader.GetString(2);
                    sNombre = mReader.GetString(3);
                    sApellido = mReader.GetString(4);
                    sDpi = mReader.GetString(5);
                    sFecha = mReader.GetString(6);
                    sSexo = mReader.GetString(7);
                    sNit = mReader.GetString(8);
                    sPuesto = mReader.GetString(9);
                    grdConsultarEmpleados.Rows.Insert(iContador,sCodigo, sDpi ,sNombre, sApellido,sSexo,sFecha,sDireccion,sEmail,sNit,sPuesto);
                    sCodigo = "";
                    sDireccion="";
                    sEmail="";
                    sNombre="";
                    sApellido="";
                    sDpi="";
                    sFecha="";
                    sSexo="";
                    sNit="";
                    sPuesto = "";
                    iContador++;
                }

            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void funUpdate(string sCodigo, string sDpi, string sNombre, string sApellido, string sSexo, string sFecha, string sDireccion, string sEmail, string sNit, string sPuesto)
        {
            try
            {
                MySqlCommand mComando = new MySqlCommand(string.Format("UPDATE PERSONA SET cdireccionpersona = '{0}', cemailpersona = '{1}',  cnombrepersona= '{2}',  capellidopersona= '{3}',  cdpipersona= '{4}',  dfechanacpersona= '{5}',  csexopersona= '{6}', cnitpersona = '{7}' WHERE persona.ncodpersona = '{8}'",
                sDireccion,sEmail,sNombre,sApellido,sDpi,sFecha,sSexo,sNit,sCodigo), clasConexion.funConexion());
                mComando.ExecuteNonQuery();
                funActualizar();
                MessageBox.Show("Se actualizo con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = "";
                funActualizar();
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void grdConsultarAseguradora_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;
            //btnBuscar.Enabled = false;
            txtNombre.Clear();
            txtDpi.Clear();
            //txtDpi.Enabled = false;
            //txtNombre.Enabled = false;

            
            DataGridViewRow fila = grdConsultarEmpleados.CurrentRow;
            sCodigoUp = Convert.ToString(fila.Cells[0].Value);
            sDpiUp = Convert.ToString(fila.Cells[1].Value);
            sNombreUp = Convert.ToString(fila.Cells[2].Value);
            sApellidoUp = Convert.ToString(fila.Cells[3].Value);
            sSexoUp = Convert.ToString(fila.Cells[4].Value);
            sFechaUp = Convert.ToString(fila.Cells[5].Value);
            sDireccionUp = Convert.ToString(fila.Cells[6].Value);
            sEmailUp = Convert.ToString(fila.Cells[7].Value);
            sNitUp = Convert.ToString(fila.Cells[8].Value);
            sPuestoUp = Convert.ToString(fila.Cells[9].Value);

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sCodigo;
            string sDireccion;
            string sEmail;
            string sNombre;
            string sApellido;
            string sDpi;
            string sFecha;
            string sSexo;
            string sNit;
            string sPuesto;

            int iContador = 0;
            grdConsultarEmpleados.Rows.Clear();

            try
            {

                if (String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtDpi.Text))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    funActualizar();
                }
                else
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format(
                    "SELECT persona.ncodpersona, cdireccionpersona,cemailpersona,cnombrepersona,capellidopersona,cdpipersona,dfechanacpersona,csexopersona,cnitpersona, ndescpuesto FROM PERSONA,PUESTO,EMPLEADO WHERE PUESTO.ncodpuesto=EMPLEADO.ncodpuesto AND PERSONA.cnombrepersona= '{0}' OR PERSONA.cdpipersona = '{1}'", txtNombre.Text, txtDpi.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();

                    while (mReader.Read())
                    {
                        sCodigo = mReader.GetString(0);
                        sDireccion = mReader.GetString(1);
                        sEmail = mReader.GetString(2);
                        sNombre = mReader.GetString(3);
                        sApellido = mReader.GetString(4);
                        sDpi = mReader.GetString(5);
                        sFecha = mReader.GetString(6);
                        sSexo = mReader.GetString(7);
                        sNit = mReader.GetString(8);
                        sPuesto = mReader.GetString(9);
                        grdConsultarEmpleados.Rows.Insert(iContador, sCodigo, sDpi, sNombre, sApellido, sSexo, sFecha, sDireccion, sEmail, sNit, sPuesto);
                        sCodigo = "";
                        sDireccion = "";
                        sEmail = "";
                        sNombre = "";
                        sApellido = "";
                        sDpi = "";
                        sFecha = "";
                        sSexo = "";
                        sNit = "";
                        sPuesto = "";
                        iContador++;
                    }
                    btnCancelar.Enabled = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            txtDpi.Text = "";
            txtNombre.Text = "";
            funActualizar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            funUpdate(sCodigoUp, sDpiUp, sNombreUp, sApellidoUp, sSexoUp, sFechaUp, sDireccionUp, sEmailUp, sNitUp, sPuestoUp);
        }
    }
}
