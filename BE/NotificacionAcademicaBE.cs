using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class NotificacionAcademicaBE 
    { 
        public int NotificacionID { get; set; } 
        public int InscripcionID { get; set; }
        public string EstudianteNombre { get; set; } 
        public int NotaObtenida { get; set; } 
        public DateTime FechaPublicacion { get; set; } 
    }
}
