using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public string ValidarLogin(string usuario, string pass)
        {
            return objetoCD.ObtenerIdDocente(usuario, pass);
        }
    }
}