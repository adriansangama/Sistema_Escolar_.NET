using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.bean
{
    internal class Distrito
    {

        #region Propiedades

        public int id_distrito { get; set; }
        public string Distrito_nombre { get; set; }

        #endregion

        #region Constructor

        public Distrito() { }

        public Distrito(int id_distrito, string distrito_nombre)
        {
            this.id_distrito = id_distrito;
            Distrito_nombre = distrito_nombre;
        }

        #endregion

    }
}