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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

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
                    MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ctipousuario FROM USUARIO WHERE cnombreusuario = '{0}' AND cpasswordusuario = '{1}' ", txtUsuario.Text, txtPass.Text), clasConexion.funConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                    {
                        sTipo = _reader.GetString(0);
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
