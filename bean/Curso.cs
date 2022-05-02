using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.bean
{
    internal class Curso
    {

        #region Propiedades

        public int id_curso { get; set; }
        public string Curso_nombre { get; set; }

        #endregion

        #region Constructor

        public Curso() { }

        public Curso(int id_curso, string curso_nombre)
        {
            this.id_curso = id_curso;
            Curso_nombre = curso_nombre;
        }

        #endregion

    }
}
