using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ReporteRecaudacionBE {
        public int ComponenteID { get; set; }
        public string CursoNombre { get; set; } 
        public decimal PrecioUnitario { get; set; }
        public int CantidadInscriptos { get; set; } 
        public decimal SubtotalRecaudado { get; set; } 
    }
}
