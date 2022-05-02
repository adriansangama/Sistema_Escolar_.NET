using System.Data;//datatable y dataset
using System.Data.SqlClient;//conexion con sql server
using System.Windows.Forms;//controles de formulario
using System.Configuration;//acceso al archivo de configuracion
using System;

namespace appSistemaEscolar.bd
{
    internal class clsBD
    {
        SqlConnection cn = null;//conexion a la base de datos
        SqlCommand cmd = null;//guarda las sentencias sql (proc_alma, vista)
        SqlDataAdapter da = null;//resultset
        public clsBD(string cnBD)//cadena de conexion a la bd
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnBD].ConnectionString);
        }
        internal int Ejecutar()//ejecutar la sentencia
        {
            if (cn.State == ConnectionState.Closed) cn.Open();//conexion
            return cmd.ExecuteNonQuery();
        }
        internal void Sentencia(string SQL)//ejecutar la sentencia
        {
            cmd = new SqlCommand(SQL, cn);
        }
        internal DataSet getDataSet()
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        internal DataTable getDataTable()
        {
            DataTable ds = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        internal DataRow getDataRow()
        {
            DataTable dt = new DataTable();

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        internal void getComboBox(ComboBox comboBox)
        {
            getComboBox(comboBox, null);
        }
        internal void getComboBox(ComboBox comboBox, string item)
        {
            DataTable dt = getDataTable();
            if (item != null)
            {
                DataRow dr = dt.NewRow();
                dr[1] = item;
                dt.Rows.InsertAt(dr, 0);
            }
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
        }

    }
}
