using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EstudianteBLL 
    { 
        private readonly EstudianteDAL estudianteDAL = new EstudianteDAL(); 
        public bool AgregarEstudiante(Estudiante estudiante) 
        { 
            ValidarEstudiante(estudiante); 
            if (estudianteDAL.ExisteDNI(estudiante.DNI)) 
            { 
                throw new Exception("Ya existe un alumno registrado con ese DNI."); 
            } 
            return estudianteDAL.Insertar(estudiante); 
        } 
        public bool ModificarEstudiante(Estudiante estudiante) 
        { 
            if (estudiante.EstudianteID <= 0) 
                { 
                throw new Exception("Debe seleccionar un alumno válido para modificar."); 
            } 

            ValidarEstudiante(estudiante); 
            if (estudianteDAL.ExisteDNI(estudiante.DNI, estudiante.EstudianteID)) 
            { 
                throw new Exception("El DNI ingresado ya pertenece a otro alumno registrado."); 
            }
            return estudianteDAL.Modificar(estudiante); 
        } 
        private void ValidarEstudiante(Estudiante estudiante)
        { 
            if (string.IsNullOrWhiteSpace(estudiante.Nombre)) 
            { 
                throw new Exception("El nombre del alumno es obligatorio."); 
            } 
            if (estudiante.DNI <= 0) 
                { 
                throw new Exception("El DNI ingresado no es válido."); 
            } 
        } 
    }
}
