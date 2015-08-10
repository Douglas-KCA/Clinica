using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
/*---------------------------------------------------------------------------------------------------------------------------------
    Programador: Josue Revolorio
    Analista: Kevin Cajbon 
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
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT cnombresucursal FROM SUCURSAL"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while (_reader.Read()){
                    sNombre = _reader.GetString(0);
                    cmbSucursal.Items.Add(sNombre);
                }
            }
            catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ncodpersona FROM PACIENTE"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                while(_reader.Read()){
                    sPersona = _reader.GetString(0);
                    MySqlCommand _comando2 = new MySqlCommand(String.Format("SELECT cnombrepersona, capellidopersona FROM PERSONA WHERE ncodpersona = '{0}' ", sPersona), clasConexion.funConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {
                        sPaciente = _reader2.GetString(0) + " " + _reader2.GetString(1);
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
                    
                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ncodpersona FROM PERSONA WHERE cnombrepersona = '{0}' AND capellidopersona = '{1}' ", nombres[0],nombres[1]), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                        sCodigoPersona = _reader.GetString(0);

                    MySqlCommand _comando2 = new MySqlCommand(String.Format("SELECT ncodpaciente FROM PACIENTE WHERE ncodpersona = '{0}' ", sCodigoPersona), clasConexion.funConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();
                    if (_reader2.Read())
                        sCodigoPaciente = _reader2.GetString(0);

                    MySqlCommand _comando3 = new MySqlCommand(String.Format("SELECT ncodsucursal FROM SUCURSAL WHERE cnombresucursal = '{0}' ", cmbSucursal.Text), clasConexion.funConexion());
                    MySqlDataReader _reader3 = _comando3.ExecuteReader();
                    if (_reader3.Read())
                        sCodigoSucursal = _reader3.GetString(0);

                    MySqlCommand comando4 = new MySqlCommand(string.Format("INSERT into CITA (ncodsucursal, ncodpaciente, dfechacita, choracita) values ('{0}','{1}','{2}','{3}')",
                    sCodigoSucursal, sCodigoPaciente, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                    comando4.ExecuteNonQuery();
                        MessageBox.Show("La cita se Genero con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
