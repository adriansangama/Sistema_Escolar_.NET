using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appSistemaEscolar.gui
{
    public partial class frmCurso : Form
    {
        bean.Curso curso = new bean.Curso();
        dao.daoCurso daoCurso = new dao.daoCurso();
        DataTable dtRegistros = new DataTable();

        bool bHayRegistros;//variable que me va a decir si hay registros
        int indexRegistro;//posicion del registro
        public frmCurso()
        {
            InitializeComponent();
        }
        private void frmCurso_Load(object sender, System.EventArgs e)
        {
            getCursos();
            Configurar(true);//visualizar y navegar por el registro
        }
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verRegistro(e.RowIndex);//obtiene la fila donde hice click
        }
        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            curso.id_curso = 0;//asignar al id=0 - si es nuevo, pongo el id en = 0
            Configurar(false);//habilito para poder editar
            verRegistro(-1);//visualizo un registro en blanco para llenar nuevos datos
        }
        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Configurar(false);
        }
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro : " + curso.id_curso, "Eliminar",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                curso.id_curso = int.Parse(txtCodigo.Text);//obtiene el dato en el txt
                daoCurso.Eliminar(curso);//envia los datos a eliminar
                getCursos();//obtengo los datos de la lista

            }
        }
        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            DataView dv = dtRegistros.DefaultView;
            dv.RowFilter = "Curso_nombre LIKE '" + txtBuscar.Text + "%'";
            dgvRegistros.DataSource = dv;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtCurso.Text.Trim() == "") //si no ingreso datos 
            {
                MessageBox.Show("Ingrese los datos correctamente...."); //muestra un mensaje en la ventana
                return;
            }
            curso.Curso_nombre = txtCurso.Text.Trim();//obtiene el dato en el txt
            daoCurso.Guardar(curso);//envia los datos a guardar
            getCursos();//obtengo los datos de la lista
            Configurar(true);//deshabilito la edicion
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            verRegistro(bHayRegistros ? indexRegistro : -1);
            Configurar(true);
        }
        private void getCursos()
        {
            dtRegistros = daoCurso.getCursos();//recuperamos la lista
            dgvRegistros.DataSource = dtRegistros;//enlazamos con la grilla
            dgvRegistros.Columns["id_Curso"].Visible = false;//ocultamos la columna id 
            dgvRegistros.Columns["Curso_nombre"].Width = dgvRegistros.Width - 3;//definimos el tamaño de la columna
            dgvRegistros.Columns["Curso_nombre"].HeaderText = "Curso";//nombre de la cabecera
            dgvRegistros.Columns["Curso_nombre"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
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
                curso.id_curso = int.Parse(dgvRegistros.Rows[index].Cells["id_Curso"].Value.ToString());
                curso.Curso_nombre = dgvRegistros.Rows[index].Cells["Curso_nombre"].Value.ToString();
            }

            txtCodigo.Text = bLimpiar ? "" : "" + curso.id_curso;
            txtCurso.Text = bLimpiar ? "" : curso.Curso_nombre;
        }
        private void Configurar(bool bOnOff)
        {
            btnAgregar.Visible = bOnOff;
            btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

            txtCurso.ReadOnly = bOnOff;
            dgvRegistros.Enabled = bOnOff;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
