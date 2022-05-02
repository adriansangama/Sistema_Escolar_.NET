using appSistemaEscolar.bean;
using System.Data;


namespace appSistemaEscolar.dao
{
    internal class daoCargo
    {
        bd.clsBD clsBD = new bd.clsBD("cnSenati");

        internal void Guardar(Cargo cargo) //guardar los datos
        {
            clsBD.Sentencia(string.Format("sp_GuardarCargo {0},'{1}'", cargo.id, cargo.Detalle));
            clsBD.Ejecutar();
        }
        internal void Eliminar(Cargo cargo)
        {
            clsBD.Sentencia(string.Format("sp_EliminarCargo {0}", cargo.id));
            clsBD.Ejecutar();
        }
        internal void Buscar(Cargo cargo)
        {
            clsBD.Sentencia(string.Format("sp_BuscarCargo {0}", cargo.Detalle));
            clsBD.Ejecutar();
        }

        internal DataTable getCargos()
        {
            clsBD.Sentencia("sp_getCargos");
            return clsBD.getDataTable();
        }
    }
}
