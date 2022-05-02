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
    public partial class frmVentana : Form
    {
        bean.Empleado empleado = new bean.Empleado();
        public frmVentana()
        {
            InitializeComponent();
            personalizar_diseño();//invocamos el metodo
        }
        public frmVentana(bean.Empleado empleado)
        {
            this.empleado = empleado;
            InitializeComponent();
        }
        private void personalizar_diseño()//crear un metodo
        {
            panelRegistroSubMenu.Visible = false;//ocultamos los paneles de submenu
            
        }
        private void ocultar_submenu()//metodo para ocultar el menu
        {
            if(panelRegistroSubMenu.Visible == true)//si esta visible 
                panelRegistroSubMenu.Visible = false;//lo ocultamos
        }
        private void mostrar_submenu(Panel subMenu)//metodo para mostrar el submenu
        {
            if (subMenu.Visible == false)
            {
                ocultar_submenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            mostrar_submenu(panelRegistroSubMenu);
        }
        private Form activeForm=null;//guardamos el antiguo formulario
        private void abrir_panelcontenedor(Form frmContenedor)
        {
            if(activeForm != null)//si existe un formulario abierto
                activeForm.Close();//lo cerramos
            activeForm = frmContenedor;//activamos el formulario nuevo
            frmContenedor.TopLevel = false;
            frmContenedor.FormBorderStyle = FormBorderStyle.None;
            frmContenedor.Dock= DockStyle.Fill;   
            panelContenedor.Controls.Add(frmContenedor);
            panelContenedor.Tag = frmContenedor;
            frmContenedor.BringToFront();
            frmContenedor.Show();
        }
        #region RegistroSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            abrir_panelcontenedor(new frmCargo());
            ocultar_submenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            abrir_panelcontenedor(new frmAlumno());
            ocultar_submenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrir_panelcontenedor(new frmProfesor());
            ocultar_submenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrir_panelcontenedor(new frmCurso());
            ocultar_submenu();
        }
        #endregion
        private void frmVentana_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = empleado.Nombres;
            lblFecha.Text = "Fecha : " + DateTime.Now.ToShortDateString();
            timHora.Start();
        }

        private void timHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora : " + DateTime.Now.ToLongTimeString();
        }

        private void pibCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación", "Salir",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
