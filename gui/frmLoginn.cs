using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaEscolar.gui
{
    public partial class frmLoginn : Form
    {
        dao.daoEmpleado daoEmpleado = new dao.daoEmpleado();
        public frmLoginn()
        {
            InitializeComponent();
        }

        private void frmLoginn_Load(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bean.Empleado empleado = new bean.Empleado();
            empleado.Usuario = txtUsuario.Text;
            empleado.Contraseña = txtContraseña.Text;
            daoEmpleado.Login(empleado);

            if (empleado.Valido)
            {
                frmVentana frm = new frmVentana(empleado);
                frm.ShowDialog();
            }  
        }
        private void btn_Enter(object sender, EventArgs e)
        {

        }
        private void btn_Leave(object sender, EventArgs e)
        {

        }

        private void pibCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación", "Salir",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text =="ID usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "ID usuario";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtUsuario.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtUsuario.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txt_Changed(object sender, EventArgs e)
        {
            {
                btnIngresar.Enabled = txtUsuario.Text.Length == txtUsuario.MaxLength &&
                                     txtContraseña.Text.Length == txtContraseña.MaxLength;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
