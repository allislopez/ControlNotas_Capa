using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Calificaciones
    {
        private CD_Calificaciones objetoCD = new CD_Calificaciones();

        public DataTable MostrarCalificacionesDocente(string idDocente)
        {
            return objetoCD.ListarCalificacionesPorDocente(idDocente);
        }

        public void GuardarNotas(string IdCalificacion, string n1, string n2, string ex) 
        {
            string id = IdCalificacion.Trim();
            double nota1 = double.Parse(n1);
            double nota2 = double.Parse(n2); 
            double examen = double.Parse(ex);
            double promedio = (nota1 + nota2 + examen) / 3.0;
            string estado = promedio >= 6 ? "Aprobado":"Reprobado" ;
                
            objetoCD.EditarCalificaciones(id, nota1,nota2,examen,promedio,estado);
        }
    }
}
