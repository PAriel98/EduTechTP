using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProgramaBE : ComponenteEducativoBE
    {
        public List<ComponenteEducativoBE> Componentes { get; set; } = new List<ComponenteEducativoBE>();

        public override bool EsProgramaCompleto
        {
            get => true;
            set { }
        }

        public override decimal Precio
        {
            get
            {
                if (Componentes != null && Componentes.Count > 0)
                {
                    return Componentes.Sum(c => c.Precio);
                }
                return base.Precio;
            }
            set => base.Precio = value;
        }

        public ProgramaBE() : base() { }

        public ProgramaBE(int id, string nombre, decimal precio)
            : base(id, nombre, precio) { }

        public void AgregarComponente(ComponenteEducativoBE componente)
        {
            if (componente != null && !Componentes.Contains(componente))
            {
                Componentes.Add(componente);
            }
        }

        public void QuitarComponente(ComponenteEducativoBE componente)
        {
            if (componente != null && Componentes.Contains(componente))
            {
                Componentes.Remove(componente);
            }
        }
    }
}


