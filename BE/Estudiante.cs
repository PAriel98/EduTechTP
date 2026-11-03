using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Estudiante : UsuarioAcademico
    {
        public double Promedio { get; set; }
        public string Regularidad { get; set; }
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
    }
}
