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
    public partial class frmProfesor : Form
    {
        bean.Profesor profesor = new bean.Profesor();
        dao.daoProfesor daoProfesor = new dao.daoProfesor();
        DataTable dtRegistros = new DataTable();
        bool bHayRegistros;//variable que me va a decir si hay registros
        int indexRegistro;//posicion del registro
        public frmProfesor()
        {
            InitializeComponent();
        }
        private void frmProfesor_Load(object sender, System.EventArgs e)
        {
            getProfesores();
            Configurar(true);//visualizar y navegar por el registro
        }
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verRegistro(e.RowIndex);//obtiene la fila donde hice click
        }
        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            profesor.id_profesor = 0;//asignar al id=0 - si es nuevo, pongo el id en = 0
            Configurar(false);//habilito para poder editar
            verRegistro(-1);//visualizo un registro en blanco para llenar nuevos datos
        }
        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Configurar(false);
        }
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro : " + profesor.id_profesor, "Eliminar",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                profesor.id_profesor = int.Parse(txtCodigo.Text);//obtiene el dato en el txt
                daoProfesor.Eliminar(profesor);//envia los datos a eliminar
                getProfesores();//obtengo los datos de la lista

            }
        }
        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            DataView dv = dtRegistros.DefaultView;
            dv.RowFilter = "Profesor_nombre LIKE '" + txtBuscar.Text + "%'";
            dgvRegistros.DataSource = dv;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtProfesor.Text.Trim() == "") //si no ingreso datos 
            {
                MessageBox.Show("Ingrese los datos correctamente...."); //muestra un mensaje en la ventana
                return;
            }
            profesor.Profesor_nombre = txtProfesor.Text.Trim();//obtiene el dato en el txt
            daoProfesor.Guardar(profesor);//envia los datos a guardar
            getProfesores();//obtengo los datos de la lista
            Configurar(true);//deshabilito la edicion
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            verRegistro(bHayRegistros ? indexRegistro : -1);
            Configurar(true);
        }
        private void getProfesores()
        {
            dtRegistros = daoProfesor.getProfesores();//recuperamos la lista
            dgvRegistros.DataSource = dtRegistros;//enlazamos con la grilla
            dgvRegistros.Columns["id_Profesor"].Visible = false;//ocultamos la columna id 
            dgvRegistros.Columns["Profesor_nombre"].Width = dgvRegistros.Width - 3;//definimos el tamaño de la columna
            dgvRegistros.Columns["Profesor_nombre"].HeaderText = "Profesor_nombre";//nombre de la cabecera
            dgvRegistros.Columns["Profesor_nombre"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.RowHeadersVisible = false;//oculto la cabecera de la fila

            bHayRegistros = dtRegistros.Rows.Count > 0;
            verRegistro(bHayRegistros ? 0 : -1);
        }
        private void verRegistro(int index)
        {
            bool bLimpiar = index == -1;

            if (!bLimpiar)
            {
                indexRegistro = index;
                profesor.id_profesor = int.Parse(dgvRegistros.Rows[index].Cells["id_Profesor"].Value.ToString());
                profesor.Profesor_nombre = dgvRegistros.Rows[index].Cells["Profesor_nombre"].Value.ToString();
            }

            txtCodigo.Text = bLimpiar ? "" : "" + profesor.id_profesor;
            txtProfesor.Text = bLimpiar ? "" : profesor.Profesor_nombre;
        }
        private void Configurar(bool bOnOff)
        {
            btnAgregar.Visible = bOnOff;
            btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

            txtProfesor.ReadOnly = bOnOff;
            dgvRegistros.Enabled = bOnOff;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
