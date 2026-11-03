using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CursoBE 
    { 
        public int ComponenteID { get; set; } 
        public string Nombre { get; set; }
        public decimal Precio { get; set; } 
        public bool EsProgramaCompleto { get; set; } }
}
