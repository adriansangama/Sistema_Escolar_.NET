using appSistemaEscolar.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.dao
{
    internal class daoProfesor
    {
        bd.clsBD clsBD = new bd.clsBD("cnSenati");

        internal void Guardar(Profesor profesor) //guardar los datos
        {
            clsBD.Sentencia(string.Format("sp_GuardarProfesor {0},'{1}'", profesor.id_profesor, profesor.Profesor_nombre));
            clsBD.Ejecutar();
        }
        internal void Eliminar(Profesor profesor)
        {
            clsBD.Sentencia(string.Format("sp_EliminarProfesor {0}", profesor.id_profesor));
            clsBD.Ejecutar();
        }
        internal void Buscar(Profesor profesor)
        {
            clsBD.Sentencia(string.Format("sp_BuscarProfesor {0}", profesor.id_profesor));
            clsBD.Ejecutar();
        }

        internal DataTable getProfesores()
        {
            clsBD.Sentencia("sp_getProfesores");
            return clsBD.getDataTable();
        }
    }
}
