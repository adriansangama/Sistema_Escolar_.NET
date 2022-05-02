using System.Data;
namespace appSistemaEscolar.bean
{
    public class Empleado
    {
        #region Propiedades
        public int id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }

        public bool Valido { get; set; }
        #endregion

        #region Constructores

        public Empleado() { }

        public Empleado(int id, string usuario,string contraseña, string nombres)
        {
            this.id = id;
            Usuario = usuario;
            Contraseña = contraseña;
            Nombres = nombres;
        }
        #endregion

        #region Metodos

        internal void setRegistro(DataRow dataRow)
        {
            Valido = false;
            if (dataRow == null) return;

            Valido = true;
            id = int.Parse(dataRow["id"].ToString());
            Usuario = dataRow["Usuario"].ToString();
            Contraseña = dataRow["Contraseña"].ToString();
            Nombres = dataRow["Nombres"].ToString().Trim();
        }
        #endregion
    }
}
