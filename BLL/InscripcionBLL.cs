using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class InscripcionBLL
    {
        private readonly InscripcionDAL inscripcionDAL = new InscripcionDAL(); public List<InscripcionCursoBE> ObtenerInscripciones()
        {
            return inscripcionDAL.ListarInscripciones();
        }

        public bool CargarNotaExamen(int inscripcionId, int nota)
        {
            if (inscripcionId <= 0)
            {
                throw new Exception("Debe seleccionar una inscripción valida de la lista.");
            }

            if (nota < 1 || nota > 10)
            {
                throw new Exception("La nota del examen debe ser un numero entero entre 1 y 10");
            }

            return inscripcionDAL.RegistrarNotaExamen(inscripcionId, nota);
        }

        public List<NotificacionAcademicaBE> ObtenerNotificaciones()
        {
            return inscripcionDAL.ListarNotificaciones();
        }
    }
}
