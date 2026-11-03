using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTech
{
    public class FamiliaBE
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<PermisosBE> Permisos { get; set; }

        public FamiliaBE()
        {
            Permisos = new List<PermisosBE>();
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
