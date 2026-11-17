using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecaudacionBLL
    {
        private readonly RecaudacionDAL recaudacionDAL = new RecaudacionDAL();
        
        public List<ReporteRecaudacionBE> ConsultarRecaudacion(DateTime fechaDesde, DateTime fechaHasta, out decimal totalGeneral, out int totalInscripciones)
        {
            if (fechaDesde > fechaHasta) { throw new Exception("La 'Fecha Desde' no puede ser posterior a la 'Fecha Hasta'."); }
            List<ReporteRecaudacionBE> lista = recaudacionDAL.ObtenerRecaudacion(fechaDesde.Date, fechaHasta.Date);

            
            totalGeneral = lista.Sum(x => x.SubtotalRecaudado);
            totalInscripciones = lista.Sum(x => x.CantidadInscriptos);

            return lista;
        }

        public List<ComponenteEducativoBE> CargarComboClases()
        {
            var lista = recaudacionDAL.ListarClasesCombo();
            lista.Insert(0, new CursoBE { ComponenteID = 0, Nombre = "[ Todas las Clases ]" });
            return lista;
        }

        public List<RecaudacionClase> ConsultarRecaudacionPorClase(int componenteId, DateTime fechaDesde, DateTime fechaHasta, out decimal totalMonto, out int totalAlumnos)
        {
            if (fechaDesde > fechaHasta)
            {
                throw new Exception("La 'Fecha Desde' no puede ser mayor que la 'Fecha Hasta'.");
            }

            int? filtroComponente = componenteId > 0 ? (int?)componenteId : null;

            var lista = recaudacionDAL.ObtenerRecaudacionPorClase(filtroComponente, fechaDesde.Date, fechaHasta.Date);

            
            totalMonto = lista.Sum(x => x.TotalRecaudado);
            totalAlumnos = lista.Sum(x => x.CantidadInscriptos);

            return lista;
        }
    }
}
