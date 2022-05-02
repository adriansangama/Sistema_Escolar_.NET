
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.bean
{
    internal class Alumno
    {
        #region Propiedades
        public int id { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Fecha_nac { get; set; }

        //public Profesor Profesor { get; set; }
        //public Curso Curso { get; set; }

        //public Distrito Distrito { get; set; }

        #endregion
        #region Constructores
        public Alumno() { }

        public Alumno(int id, string dni, string nombres, string apellidos, string celular, string email, string fecha_nac,Profesor profesor,Curso curso,Distrito distrito)
        {
            this.id = id;
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Celular = celular;
            Email = email;
            Fecha_nac = fecha_nac;
            //Profesor=profesor;
            //Curso = curso;
            //Distrito = distrito;
        }
        #endregion
        #region Metodos
        internal void setRegistro(DataRow dataRow)
        {
            if (dataRow == null) return;

            //Profesor = new Profesor();
            //Curso = new Curso();
            //Distrito = new Distrito();

            id = int.Parse(dataRow["id"].ToString());
            Dni = dataRow["Dni"].ToString();
            Nombres = dataRow["Nombres"].ToString().Trim();
            Apellidos = dataRow["Apellidos"].ToString();
            Celular=dataRow["Celular"].ToString();
            Email = dataRow["Email"].ToString();
            Fecha_nac = dataRow["Fecha_nac"].ToString();
            //Profesor.id_profesor= int.Parse(dataRow["idProfesor"].ToString());
            //Profesor.Profesor_nombre= dataRow[".Profesor_nombre"].ToString().Trim();
            //Curso.id_curso = int.Parse(dataRow["idCurso"].ToString());
            //Curso.Curso_nombre = dataRow["Curso_nombre"].ToString().Trim();
            //Distrito.id_distrito = int.Parse(dataRow["idDistrito"].ToString());
            //Distrito.Distrito_nombre = dataRow["Distrito_nombre"].ToString().Trim();

        }

        #endregion
    }
}
