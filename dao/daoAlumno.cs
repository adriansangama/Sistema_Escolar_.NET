using appSistemaEscolar.bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appSistemaEscolar.dao
{
    internal class daoAlumno
    {
        bd.clsBD clsBD = new bd.clsBD("cnSenati");

        internal void Guardar(Alumno alumno) //guardar los datos
        {
            clsBD.Sentencia(string.Format("sp_GuardarAlumno {0},'{1}','{2}','{3}','{4}','{5}','{6}'", 
            alumno.id, alumno.Dni,alumno.Nombres,alumno.Apellidos,alumno.Celular,alumno.Email,alumno.Fecha_nac));
            clsBD.Ejecutar();
        }
        internal void Eliminar(Alumno alumno)
        {
            clsBD.Sentencia(string.Format("sp_EliminarAlumno {0}", alumno.id));
            clsBD.Ejecutar();
        }
        internal void Buscar(Alumno alumno)
        {
            clsBD.Sentencia(string.Format("sp_BuscarAlumno {0}", alumno.id));
            clsBD.Ejecutar();
        }

        internal DataTable getAlumnos()
        {
            clsBD.Sentencia("sp_getAlumnos");
            return clsBD.getDataTable();
        }

        internal void getProfesores(ComboBox cboProfesor)
        {
            clsBD.Sentencia("sp_getProfesores");
            clsBD.getComboBox(cboProfesor, "Seleccionar");
        }

        internal void getCursos(ComboBox cboCurso)
        {
            clsBD.Sentencia("sp_getCursos");
            clsBD.getComboBox(cboCurso, "Seleccionar");
        }

        internal void getDistritos(ComboBox cboDistrito)
        {
            clsBD.Sentencia("sp_getDistritos");
            clsBD.getComboBox(cboDistrito, "Seleccionar");
        }
    }
}
