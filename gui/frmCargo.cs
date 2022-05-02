using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace appSistemaEscolar.gui
{
    public partial class frmCargo : Form
    {
        bean.Cargo cargo = new bean.Cargo();
        dao.daoCargo daoCargo = new dao.daoCargo();
        DataTable dtRegistros = new DataTable();

        bool bHayRegistros;//variable que me va a decir si hay registros
        int indexRegistro;//posicion del registro
        public frmCargo()
        {
            InitializeComponent();
        }
        private void frmCargo_Load(object sender, System.EventArgs e)
        {
            getCargos();
            Configurar(true);//visualizar y navegar por el registro
        }
        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verRegistro(e.RowIndex);//obtiene la fila donde hice click
        }
        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            cargo.id = 0;//asignar al id=0 - si es nuevo, pongo el id en = 0
            Configurar(false);//habilito para poder editar
            verRegistro(-1);//visualizo un registro en blanco para llenar nuevos datos
        }
        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            Configurar(false);
        }
        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el registro : " + cargo.id, "Eliminar",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cargo.id = int.Parse(txtCodigo.Text);//obtiene el dato en el txt
                daoCargo.Eliminar(cargo);//envia los datos a eliminar
                getCargos();//obtengo los datos de la lista

            }
        }
        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            DataView dv = dtRegistros.DefaultView;
            dv.RowFilter = "Detalle LIKE '" + txtBuscar.Text + "%'";
            dgvRegistros.DataSource = dv;
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtCargo.Text.Trim() == "") //si no ingreso datos 
            {
                MessageBox.Show("Ingrese los datos correctamente...."); //muestra un mensaje en la ventana
                return;
            }
            cargo.Detalle = txtCargo.Text.Trim();//obtiene el dato en el txt
            daoCargo.Guardar(cargo);//envia los datos a guardar
            getCargos();//obtengo los datos de la lista
            Configurar(true);//deshabilito la edicion
        }
        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            verRegistro(bHayRegistros ? indexRegistro : -1);
            Configurar(true);
        }
        private void getCargos()
        {
            dtRegistros = daoCargo.getCargos();//recuperamos la lista
            dgvRegistros.DataSource = dtRegistros;//enlazamos con la grilla
            dgvRegistros.Columns["id"].Visible = false;//ocultamos la columna id 
            dgvRegistros.Columns["Detalle"].Width = dgvRegistros.Width - 3;//definimos el tamaño de la columna
            dgvRegistros.Columns["Detalle"].HeaderText = "Cargo";//nombre de la cabecera
            dgvRegistros.Columns["Detalle"].Resizable = DataGridViewTriState.False;//bloquear el tamaño de la columna
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
                cargo.id = int.Parse(dgvRegistros.Rows[index].Cells["id"].Value.ToString());
                cargo.Detalle = dgvRegistros.Rows[index].Cells["Detalle"].Value.ToString();
            }

            txtCodigo.Text = bLimpiar ? "" : "" + cargo.id;
            txtCargo.Text = bLimpiar ? "" : cargo.Detalle;
        }
        private void Configurar(bool bOnOff)
        {
            btnAgregar.Visible = bOnOff;
            btnEditar.Visible = btnEliminar.Visible = bOnOff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnOff;

            txtCargo.ReadOnly = bOnOff;
            dgvRegistros.Enabled = bOnOff;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
