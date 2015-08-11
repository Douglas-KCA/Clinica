using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
/*---------------------------------------------------------------------------------------------------------------------------------
   Programador y Analista: Josue Revolorio
   * Fecha de asignacion: 03/08/2015
   * Fecha de entrega: 07/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmIngresoCita : Form
    {

        public frmIngresoCita()
        {
            InitializeComponent();
            funCargarCombos();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que carga los datos a los combos del programa al iniciar el form
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void funCargarCombos()
        {
            String sNombre;
            String sPersona;
            String sPaciente;

            try{
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT cnombresucursal FROM SUCURSAL"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read()){
                    sNombre = mReader.GetString(0);
                    cmbSucursal.Items.Add(sNombre);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM PACIENTE"), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();
                while(mReader.Read()){
                    sPersona = mReader.GetString(0);
                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM PERSONA WHERE ncodpersona = '{0}' ", sPersona), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    while (mReader2.Read())
                    {
                        sPaciente = mReader2.GetString(0) + " " + mReader2.GetString(1);
                        cmbPaciente.Items.Add(sPaciente);
                    }
                    sPersona = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Funcion que guarda los datos de la cita en la BD y las añade a la tabla en el form 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sCodigoPaciente = "";
            String sCodigoSucursal = ""; 
            String sCodigoPersona = "";
            try{
                if (String.IsNullOrEmpty(cmbSucursal.Text) || String.IsNullOrEmpty(cmbPaciente.Text) || String.IsNullOrEmpty(cmbHora.Text) || String.IsNullOrEmpty(cmbMinutos.Text)){
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else{
                    String[] nombres = cmbPaciente.Text.Split(' ');
                    
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ncodpersona FROM PERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}' ", nombres[0],nombres[1]), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                        sCodigoPersona = mReader.GetString(0);

                    MySqlCommand mComando2 = new MySqlCommand(String.Format("SELECT ncodpaciente FROM PACIENTE WHERE ncodpersona = '{0}' ", sCodigoPersona), clasConexion.funConexion());
                    MySqlDataReader mReader2 = mComando2.ExecuteReader();
                    if (mReader2.Read())
                        sCodigoPaciente = mReader2.GetString(0);

                    MySqlCommand mComando3 = new MySqlCommand(String.Format("SELECT ncodsucursal FROM SUCURSAL WHERE cnombresucursal = '{0}' ", cmbSucursal.Text), clasConexion.funConexion());
                    MySqlDataReader mReader3 = mComando3.ExecuteReader();
                    if (mReader3.Read())
                        sCodigoSucursal = mReader3.GetString(0);

                    MySqlCommand mComando4 = new MySqlCommand(String.Format("SELECT ncodigocita FROM CITA WHERE dfechacita = '{0}' AND choracita = '{1}'", dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                    MySqlDataReader mReader4 = mComando4.ExecuteReader();
                    if (mReader4.Read()) {
                        MessageBox.Show("Ya se tiene una cita para esa fecha y hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MySqlCommand comando4 = new MySqlCommand(string.Format("INSERT into CITA (ncodsucursal, ncodpaciente, dfechacita, choracita) values ('{0}','{1}','{2}','{3}')",
                        sCodigoSucursal, sCodigoPaciente, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                        comando4.ExecuteNonQuery();
                        MessageBox.Show("La cita se Genero con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
          Limpia los textbox o combobox 
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbHora.Text = "";
            cmbMinutos.Text = "";
            cmbPaciente.Text = "";
            cmbSucursal.Text = "";
        }

    }
}
