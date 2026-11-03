using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Docente : UsuarioAcademico
    {
        public string Titulo { get; set; }
        public double ValordeHora { get; set; }
    }
}
