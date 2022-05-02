using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.bean
{
    internal class Profesor
    {

        #region Propiedades

        public int id_profesor { get; set; }
        public string Profesor_nombre { get; set; }

        #endregion

        #region Constructor

        public Profesor() { }

        public Profesor(int id_profesor, string profesor_nombre)
        {
            this.id_profesor = id_profesor;
            Profesor_nombre = profesor_nombre;
        }

        #endregion

    }
}
