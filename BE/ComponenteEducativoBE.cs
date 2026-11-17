using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ComponenteEducativoBE : IComparable<ComponenteEducativoBE>
    {
        public int ComponenteID { get; set; }
        public string Nombre { get; set; }
        public virtual decimal Precio { get; set; }
        public virtual bool EsProgramaCompleto { get; set; }

        public ComponenteEducativoBE() { }

        public ComponenteEducativoBE(int id, string nombre, decimal precio)
        {
            ComponenteID = id;
            Nombre = nombre;
            Precio = precio;
        }

        public int CompareTo(ComponenteEducativoBE other)
        {
            if (other == null) return 1;
            return string.Compare(this.Nombre, other.Nombre, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
