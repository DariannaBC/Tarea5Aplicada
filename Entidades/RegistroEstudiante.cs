using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5Aplicada.Entidades
{
    public class RegistroEstudiante
    {
        public string NombreEstudiante { get; set; }
        public int EdadEstudiante { get; set; }
        public string AulaEstudiante { get; set; }
        public DateTime FechaDeNacimientoEstudiante { get; set; }

        public RegistroEstudiante()
        {
            NombreEstudiante = "";
            EdadEstudiante = 0;
            AulaEstudiante = "";
            FechaDeNacimientoEstudiante = DateTime.Now;
        }

        public RegistroEstudiante(string nombreestudiante, int edadestudiante, string aulaestudiante, DateTime fechadenacimientoestudiante)
        {
            NombreEstudiante = nombreestudiante;
            EdadEstudiante = edadestudiante;
            AulaEstudiante = aulaestudiante;
            FechaDeNacimientoEstudiante = fechadenacimientoestudiante;
        }
    }
}
