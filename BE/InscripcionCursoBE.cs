using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InscripcionCursoBE 
    { 
        public int InscripcionID { get; set; } 
        public int EstudianteID { get; set;} 
        public string EstudianteNombre { get; set; } 
        public int ComponenteID { get; set; } 
        public string CursoNombre { get; set; }
        public DateTime FechaInscripcion { get; set; } 
        public int? NotaExamenFinal { get; set; } 
    }
}
