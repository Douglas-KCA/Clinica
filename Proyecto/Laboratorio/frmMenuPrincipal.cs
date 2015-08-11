using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(String tipo)
        {
            InitializeComponent();
            if(tipo == "secre"){
                mOtros.Enabled = false;
            }else if (tipo == "doc")
            {
                mPaciente.Enabled = false;
                mEmpleado.Enabled = false;
                mCitas.Enabled = false;
                mCotizacion.Enabled = false;
                mAnalisis.Enabled = false;
                mOtros.Enabled = false;
            }
        }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente ver = new frmPaciente();
            ver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea cerrar sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogIn ver = new frmLogIn();
                ver.Show();
                this.Close();
            }  
            
        }

        private void mCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAseguradora ver = new frmAseguradora();
            ver.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sbmModificarPaciente_Click(object sender, EventArgs e)
        {
            frmConsultaPacientes ver = new frmConsultaPacientes();
            ver.Show();
        }

        private void sbmIngresarCitas_Click(object sender, EventArgs e)
        {
            frmIngresoCita ver = new frmIngresoCita();
            ver.Show();
        }

        private void sbmModificarCitas_Click(object sender, EventArgs e)
        {
            frmConsultaCita ver = new frmConsultaCita();
            ver.Show();
        }

        private void sbmCrearEtiqueta_Click(object sender, EventArgs e)
        {
            frmMuestra muestra = new frmMuestra();
            muestra.Show();
        }

        private void sbmIngresarExamenes_Click(object sender, EventArgs e)
        {

        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAseguradora ver = new frmAseguradora();
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAseguradora ver = new frmConsultaAseguradora();
            ver.Show();
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSucursal ver = new frmSucursal();
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSucursal ver = new frmConsultaSucursal();
            ver.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuesto ver = new frmPuesto();
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarPuesto ver = new frmConsultarPuesto();
            ver.Show();
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTarifaSeguro ver = new frmTarifaSeguro();
            ver.Show();
        }

        private void consultarYModificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultarTarifa ver = new frmConsultarTarifa();
            ver.Show();
        }

        private void msbmIngresar_Click(object sender, EventArgs e)
        {
            frmMembresia ver = new frmMembresia();
            ver.Show();
        }

        private void msbmConsultaryModificar_Click(object sender, EventArgs e)
        {
            frmConsultaMembresia ver = new frmConsultaMembresia();
            ver.Show();
        }

//<<<<<<< HEAD
        private void consultaYModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSeguro ver = new frmSeguro();
        }
//=======
//<<<<<<< HEAD
        private void sbmConsultaMuestra_Click(object sender, EventArgs e)
        {
            frmConsultaMuestra ver = new frmConsultaMuestra();
            ver.Show();
        }

        private void sbmIngresarMuestra_Click(object sender, EventArgs e)
        {
            frmMuestra ver = new frmMuestra();
        }
//=======
        private void sbmIngresarEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados ver = new frmEmpleados();
//>>>>>>> master
//>>>>>>> master
            ver.Show();
        }
    }
}
