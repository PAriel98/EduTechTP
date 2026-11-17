using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class DocenteBLL
    {
        private readonly DocenteDAL docenteDAL = new DocenteDAL();
        public bool GuardarDocente(Docente docente)
        {
            if (string.IsNullOrWhiteSpace(docente.Legajo))
                throw new Exception("El Legajo es obligatorio.");
            if (string.IsNullOrWhiteSpace(docente.Nombre) || string.IsNullOrWhiteSpace(docente.Apellido))
                throw new Exception("El Nombre y Apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(docente.DNI))
                throw new Exception("El DNI es obligatorio.");
            if (string.IsNullOrWhiteSpace(docente.Titulo))
                throw new Exception("El Título profesional es obligatorio.");
            if (docente.ValordeHora <= 0)
                throw new Exception("El Valor de Hora Cátedra debe ser mayor a 0.");
            if (docente.DocenteID == 0)
            {
                return docenteDAL.InsertarDocente(docente);
            }
            else
            {
                return docenteDAL.ModificarDocente(docente);
            }
        }
        public bool EliminarDocente(int docenteId)
        {
            if (docenteId <= 0)
                throw new Exception("Debe seleccionar un docente válido para eliminar.");
            return docenteDAL.EliminarDocente(docenteId);
        }
        public List<Docente> ObtenerDocentes()
        {
            return docenteDAL.ListarDocentes();
        }
    }
}