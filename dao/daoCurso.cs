using appSistemaEscolar.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.dao
{
    internal class daoCurso
    {
        bd.clsBD clsBD = new bd.clsBD("cnSenati");

        internal void Guardar(Curso curso) //guardar los datos
        {
            clsBD.Sentencia(string.Format("sp_GuardarCurso {0},'{1}'", curso.id_curso, curso.Curso_nombre));
            clsBD.Ejecutar();
        }
        internal void Eliminar(Curso curso)
        {
            clsBD.Sentencia(string.Format("sp_EliminarCurso {0}", curso.id_curso));
            clsBD.Ejecutar();
        }
        internal void Buscar(Curso curso)
        {
            clsBD.Sentencia(string.Format("sp_BuscarCurso {0}", curso.id_curso));
            clsBD.Ejecutar();
        }

        internal DataTable getCursos()
        {
            clsBD.Sentencia("sp_getCursos");
            return clsBD.getDataTable();
        }
    }
}
