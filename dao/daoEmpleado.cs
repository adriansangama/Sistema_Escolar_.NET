using appSistemaEscolar.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaEscolar.dao
{
    internal class daoEmpleado
    {
        bd.clsBD clsBD = new bd.clsBD("cnSenati");

        internal void Login(Empleado empleado)
        {
            clsBD.Sentencia("sp_Empleado_Login " + empleado.Usuario + "," + empleado.Contraseña);
            empleado.setRegistro(clsBD.getDataRow());
        }
    }
}
