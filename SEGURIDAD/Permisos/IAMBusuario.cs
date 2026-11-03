using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTech
{
    public interface IAMBusuario <x>
    {
        void Agregar(x objeto);
        void Modificar(x objeto);
        void Eliminar(string criterio, string criterio2);
        List<x> buscar(string criterio, string criterio2);
        List<x> Listar();
        void GuardarNLista(List<x> lista);
    }
}
