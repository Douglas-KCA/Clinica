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
    public partial class frmIngresoCita : Form
    {
        public frmIngresoCita()
        {
            InitializeComponent();
            funCargarCombos();
        }

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

            try{
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ncodpersona FROM PACIENTE"), clasConexion.funConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();

                while(_reader.Read()){
                    sPersona = _reader.GetString(0);
                    _comando = new MySqlCommand(String.Format("SELECT cnombrepersona FROM PERSONA WHERE ncodpersona = '{0}' ", sPersona), clasConexion.funConexion());
                    MySqlDataReader _reader2 = _comando.ExecuteReader();

                    while(_reader.Read()){
                        sPaciente = _reader.GetString(0);
                        cmbSucursal.Items.Add(sPaciente);
                    }
                }
            }
            catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String sCodigoPaciente;
            String sCodigoSucursal;
            try{
                if (String.IsNullOrEmpty(cmbSucursal.Text) || String.IsNullOrEmpty(cmbPaciente.Text) || String.IsNullOrEmpty(cmbHora.Text) || String.IsNullOrEmpty(cmbMinutos.Text)){
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else{
                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ncodpaciente FROM PACIENTE"), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    
                    if (_reader.Read()){
                        sCodigoPaciente = _reader.GetString(0);
                        MySqlCommand _comando2 = new MySqlCommand(String.Format("SELECT ncodsucursal FROM SUCURSAL"), clasConexion.funConexion());
                        MySqlDataReader _reader2 = _comando.ExecuteReader();

                        if (_reader2.Read())
                        {
                            sCodigoSucursal = _reader2.GetString(0);
                            MySqlCommand comando = new MySqlCommand(string.Format("Insert into CITA (ncodsucrsual, ncodpaciente, dfechacita, choracita) values ('{0}','{1}','{2}','{3}')",
                            sCodigoSucursal, sCodigoPaciente, dtpCitas.Text, cmbHora.Text + ":" + cmbMinutos.Text), clasConexion.funConexion());
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Se inserto con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }catch{
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblUbicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
