using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace appSistemaEscolar.gui
{
    public partial class frmAlumno : Form
    {
        bean.Alumno alumno = new bean.Alumno();
        dao.daoAlumno daoAlumno = new dao.daoAlumno();
        DataTable dtRegistros = new DataTable();

        bool bHayRegistros;//variable que me va a decir si hay registros
        int indexRegistro;//posicion del registro
        public frmAlumno()
        {
            InitializeComponent();
        }
        private void frmAlumno_Load(object sender, System.EventArgs e)
        {
            getAlumnos();
            Configurar(true);//visualizar y navegar por el registro
            getProfesores();
            getCursos();
            getDistritos();
        }
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verRegistro(e.RowIndex);//obtiene la fila donde hice click
        }
        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            alumno.id = 0;//asignar al id=0 - si es nuevo, pongo el id en = 0
            Configurar(false);//habilito para poder editar
            verRegistro(-1);//visualizo un registro en blanco para llenar nuevos datos
        }
        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Configurar(false);
        }
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro : " + alumno.id, "Eliminar",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                alumno.id = int.Parse(txtCodigo.Text);//obtiene el dato en el txt
                daoAlumno.Eliminar(alumno);//envia los datos a eliminar
                getAlumnos();//obtengo los datos de la lista

            }
        }
        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            DataView dv = dtRegistros.DefaultView;
            dv.RowFilter = "Nombres LIKE '" + txtBuscar.Text + "%'";
            dgvRegistros.DataSource = dv;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtDni.Text.Trim() == "" && txtNombres.Text.Trim() == "" && txtApellidos.Text.Trim() == "" && txtCelular.Text.Trim() == "" &&
                txtEmail.Text.Trim() == "" && txtFecha.Text.Trim() == "" )//si no ingreso datos 
            {
                MessageBox.Show("Ingrese los datos correctamente...."); //muestra un mensaje en la ventana
                return;
            }
            alumno.Dni = txtDni.Text.Trim();//obtiene el dato en el txt
            alumno.Nombres = txtNombres.Text.Trim();//obtiene el dato en el txt
            alumno.Apellidos = txtApellidos.Text.Trim();//obtiene el dato en el txt
            alumno.Celular = txtCelular.Text.Trim();//obtiene el dato en el txt
            alumno.Email = txtEmail.Text.Trim();//obtiene el dato en el txt
            alumno.Fecha_nac = txtFecha.Text.Trim();//obtiene el dato en el txt
            daoAlumno.Guardar(alumno);//envia los datos a guardar
            getAlumnos();//obtengo los datos de la lista
            Configurar(true);//deshabilito la edicion
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            verRegistro(bHayRegistros ? indexRegistro : -1);
            Configurar(true);
        }
        private void getAlumnos()
        {
            dtRegistros = daoAlumno.getAlumnos();//recuperamos la lista
            dgvRegistros.DataSource = dtRegistros;//enlazamos con la grilla
            dgvRegistros.Columns["id"].Visible = false;//ocultamos la columna id 
            dgvRegistros.Columns["Dni"].HeaderText = "Dni";//nombre de la cabecera
            dgvRegistros.Columns["Dni"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.Columns["Nombres"].HeaderText = "Nombres";//nombre de la cabecera
            dgvRegistros.Columns["Nombres"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.Columns["Apellidos"].HeaderText = "Apellidos";//nombre de la cabecera
            dgvRegistros.Columns["Apellidos"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.Columns["Celular"].HeaderText = "Celular";//nombre de la cabecera
            dgvRegistros.Columns["Celular"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.Columns["Email"].HeaderText = "Email";//nombre de la cabecera
            dgvRegistros.Columns["Email"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
            dgvRegistros.Columns["Fecha_nac"].HeaderText = "Fecha";//nombre de la cabecera
            dgvRegistros.Columns["Fecha_nac"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
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
                alumno.id = int.Parse(dgvRegistros.Rows[index].Cells["id"].Value.ToString());
                alumno.Dni = dgvRegistros.Rows[index].Cells["Dni"].Value.ToString();
                alumno.Nombres = dgvRegistros.Rows[index].Cells["Nombres"].Value.ToString();
                alumno.Apellidos = dgvRegistros.Rows[index].Cells["Apellidos"].Value.ToString();
                alumno.Celular = dgvRegistros.Rows[index].Cells["Celular"].Value.ToString();
                alumno.Email = dgvRegistros.Rows[index].Cells["Email"].Value.ToString();
                alumno.Fecha_nac = dgvRegistros.Rows[index].Cells["Fecha_nac"].Value.ToString();

            }

            txtCodigo.Text = bLimpiar ? "" : "" + alumno.id;
            txtDni.Text = bLimpiar ? "" : alumno.Dni;
            txtNombres.Text = bLimpiar ? "" : alumno.Nombres;
            txtApellidos.Text = bLimpiar ? "" : alumno.Apellidos;
            txtCelular.Text = bLimpiar ? "" : alumno.Celular;
            txtEmail.Text = bLimpiar ? "" : alumno.Email;
            txtFecha.Text = bLimpiar ? "" : alumno.Fecha_nac;
        }
        private void Configurar(bool bOnOff)
        {
            btnAgregar.Visible = bOnOff;
            btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

            txtDni.ReadOnly = bOnOff;
            txtNombres.ReadOnly = bOnOff;
            txtApellidos.ReadOnly = bOnOff;
            txtCelular.ReadOnly = bOnOff;
            txtEmail.ReadOnly = bOnOff;
            txtFecha.ReadOnly = bOnOff;
            dgvRegistros.Enabled = bOnOff;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void getProfesores()
        {
            //daoAlumno.getProfesores( cboProfesor );
        }
        private void getCursos()
        {
            //daoAlumno.getCursos(cboCurso); 
        }
        private void getDistritos()
        {
            //daoAlumno.getDistritos(cboDistrito);
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }
    }
}
