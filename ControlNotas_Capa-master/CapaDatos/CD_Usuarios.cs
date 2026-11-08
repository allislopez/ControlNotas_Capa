using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        public string ObtenerIdDocente(string usuario, string pass)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "SELECT Id_Docente FROM Docente WHERE (Usuario = @user OR Id_Docente = @user) AND Contrasena = @pass";
            comando.Parameters.AddWithValue("@user", usuario);
            comando.Parameters.AddWithValue("@pass", pass);

            object resultado = comando.ExecuteScalar(); 
            conexion.CerrarConexion();

            if (resultado != null)
            {
                return resultado.ToString(); 
            }
            else
            {
                return null;
            }
        }
    }
}