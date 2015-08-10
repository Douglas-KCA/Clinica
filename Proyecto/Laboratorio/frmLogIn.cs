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
/*---------------------------------------------------------------------------------------------------------------------------------
  Programador y Analista: Josue Revolorio
* Fecha de asignacion: 07/08/2015
* Fecha de entrega: 10/08/2015
---------------------------------------------------------------------------------------------------------------------------------*/
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------------------------------------------------------------
           Funcion que obtiene el tipo de usuario que se ingresa y envia un parametro al form del menu principal para bloquear o
           avilitar opciones del menu principal
        ---------------------------------------------------------------------------------------------------------------------------------*/
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String sTipo;
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor llene nombre de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    MySqlCommand mComando = new MySqlCommand(String.Format("SELECT ctipousuario FROM USUARIO WHERE cnombreusuario = '{0}' AND cpasswordusuario = '{1}' ", txtUsuario.Text, txtPass.Text), clasConexion.funConexion());
                    MySqlDataReader mReader = mComando.ExecuteReader();
                    if (mReader.Read())
                    {
                        sTipo = mReader.GetString(0);
                        if (sTipo == "secre")
                        {
                            frmMenuPrincipal ver = new frmMenuPrincipal(sTipo);
                            ver.Show();
                            this.Hide();
                        }
                        else if (sTipo == "doc")
                        {
                            frmMenuPrincipal ver = new frmMenuPrincipal(sTipo);
                            ver.Show();
                            this.Hide();
                        }
                        else if (sTipo == "admin")
                        {
                            frmMenuPrincipal ver = new frmMenuPrincipal(sTipo);
                            ver.Show();
                            this.Hide();
                        }
                    }
                }
                catch {
                    MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
