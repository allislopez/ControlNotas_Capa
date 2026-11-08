using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Calificaciones
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable ListarCalificacionesPorDocente(string idDocente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = @"
                SELECT 
                    c.Id_Califcacion,
                    e.Id_Estudiante,
                    (e.Nombres + ' ' + e.Apellidos) AS Estudiante,
                    m.Nombre_Materia,
                    c.Nota_1,
                    c.Nota_2,
                    c.Examen,
                    c.Promedio,
                    c.Estado
                FROM Calificaciones c
                INNER JOIN Estudiantes e ON c.Id_Estudiante = e.Id_Estudiante
                INNER JOIN Carga_Academica ca ON c.Id_Carga = ca.Id_Carga
                INNER JOIN Materia m ON ca.Id_Materia = m.Id_Materia";
                

            comando.CommandType = CommandType.Text;

            SqlDataReader leer = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void EditarCalificaciones(string IdCalificacion, double nota1, double nota2, double examen, double promedio, string estado)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = @"
                UPDATE Calificaciones
                SET Nota_1 = @Nota_1,
                    Nota_2 = @Nota_2,
                    Examen = @Examen,
                    Promedio = @Promedio,
                    Estado = @Estado
                WHERE Id_Califcacion = @Id_Califcacion";

            comando.Parameters.AddWithValue("@Nota_1", nota1);
            comando.Parameters.AddWithValue("@Nota_2", nota2);
            comando.Parameters.AddWithValue("@Examen", examen);
            comando.Parameters.AddWithValue("@Promedio", promedio);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Id_Califcacion", IdCalificacion);

            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            conexion.CerrarConexion();
        }
    }
}