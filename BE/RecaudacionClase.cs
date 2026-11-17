using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class RecaudacionClase
    {
        public int ComponenteID { get; set; }
        public string ClaseNombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int CantidadInscriptos { get; set; }
        public decimal TotalRecaudado { get; set; }
    }
}
