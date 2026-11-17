using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CursoBE : ComponenteEducativoBE
    {
        private bool esProgramaCompleto = false; 
        public override bool EsProgramaCompleto 
        {
            get => false; 
            set => esProgramaCompleto = false;
        } 
        public CursoBE() : base() { }
        public CursoBE(int id, string nombre, decimal precio) : base(id, nombre, precio) { }
    }
}
