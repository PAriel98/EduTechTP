using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CursoBLL
    {
        private readonly CursoDAL cursoDAL = new CursoDAL(); 
        public bool AgregarCurso(CursoBE curso) 
        { 
            ValidarCurso(curso); 
            return cursoDAL.Insertar(curso); 
        }
        public bool ModificarCurso(CursoBE curso)
        { 
            if (curso.ComponenteID <= 0) 
            { 
                throw new Exception("Debe seleccionar un curso válido para modificar.");
            } 
            ValidarCurso(curso); 
            return cursoDAL.Modificar(curso); }
        public List<CursoBE> ListarCursos()
        {
            return cursoDAL.Listar();
        }

        private void ValidarCurso(CursoBE curso)
        {
            if (string.IsNullOrWhiteSpace(curso.Nombre))
            {
                throw new Exception("El nombre del curso es obligatorio.");
            }

            if (curso.Precio <= 0)
            {
                throw new Exception("El precio debe ser un valor positivo.");
            }
        }

        public DataTable ObtenerInscriptosPorCurso() 
        { 
            return cursoDAL.ObtenerInscriptosPorCurso();
        }
        public DataTable ObtenerPromediosPorCurso() 
        { 
            return cursoDAL.ObtenerPromediosPorCurso(); 
        }
        public DataTable ObtenerAprobadosVsReprobados()
        { 
            return cursoDAL.ObtenerAprobadosVsReprobados();
        }
    }
}
