using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduTech
{
    public class FamiliaBLL
    {
        public void AgregarPermiso(FamiliaBE familia,PermisosBE permiso)
        {
            familia.Permisos.Add(permiso);
        }

        public void QuitarPermiso(FamiliaBE familia,PermisosBE permiso)
        {
            familia.Permisos.Remove(permiso);
        }


        private static List<PermisosBE> permisos = new List<PermisosBE>();

        private static List<FamiliaBE> familias =new List<FamiliaBE>();

        public List<FamiliaBE> ObtenerFamilias()
        {
            return familias;
        }

        public List<PermisosBE> ObtenerTodosLosPermisos()
        {
            return permisos;
        }

        private static string ruta = "familias.txt";

        
        public void GuardarFamilia()
        {
            if (familias.Count == 0)
            {
                Seguridad.Guardar(ruta, "", false); 
                return;
            }

            bool append = false; 
            foreach (var familia in familias)
            {                
                string idsPermisos = string.Join(",", familia.Permisos.Select(p => p.Id));              
                string linea = $"{familia.Id}|{familia.Nombre}|{idsPermisos}";

                Seguridad.Guardar(ruta, linea, append);
                append = true;
            }
        }

        public void CrearFamilia(FamiliaBE familia)
        {
            familias.Add(familia);
            GuardarFamilia();
        }

        public void ModificarFamilia(FamiliaBE familia)
        {
            FamiliaBE existente =familias.FirstOrDefault( f => f.Id == familia.Id);

            if (existente != null)
            {
                existente.Nombre =familia.Nombre;

                existente.Permisos =familia.Permisos;

                GuardarFamilia();
            }
        }

        public void EliminarFamilia(int id)
        {
            FamiliaBE familia = familias.FirstOrDefault(f => f.Id == id);

            if (familia != null)
                familias.Remove(familia);

            GuardarFamilia();
        }

        public FamiliaBLL()
        {
            
            if (permisos.Count == 0)
            {
                permisos.Add(new PermisosBE() { Id = 1, Nombre = "GESTIONAR_USUARIOS" });
                permisos.Add(new PermisosBE() { Id = 2, Nombre = "GESTIONAR_PERSONAL" });
                permisos.Add(new PermisosBE() { Id = 3, Nombre = "VER_BITACORA" });
                permisos.Add(new PermisosBE() { Id = 4, Nombre = "CAMBIAR_IDIOMA" });
                permisos.Add(new PermisosBE() { Id = 5, Nombre = "BACKUP" });
                permisos.Add(new PermisosBE() { Id = 6, Nombre = "RESTORE" });
            }

           
            if (familias.Count == 0)
            {
                var lineas = Seguridad.Leer(ruta);

                if (lineas.Length > 0 && !string.IsNullOrWhiteSpace(lineas[0]))
                {
                    foreach (var linea in lineas)
                    {
                        var partes = linea.Split('|');
                        var f = new FamiliaBE();
                        f.Id = int.Parse(partes[0]);
                        f.Nombre = partes[1];

                        
                        if (partes.Length > 2 && !string.IsNullOrEmpty(partes[2]))
                        {
                            var idsDePermisos = partes[2].Split(',');
                            foreach (var id in idsDePermisos)
                            {
                                var permisoRelacionado = permisos.FirstOrDefault(p => p.Id == int.Parse(id));
                                if (permisoRelacionado != null)
                                {
                                    f.Permisos.Add(permisoRelacionado);
                                }
                            }
                        }
                        familias.Add(f);
                    }
                }
                else
                {
                    
                    FamiliaBE admin = new FamiliaBE() { Id = 1, Nombre = "ADMINISTRADOR" };
                    admin.Permisos.Add(permisos[0]);
                    admin.Permisos.Add(permisos[1]);
                    admin.Permisos.Add(permisos[2]);
                    admin.Permisos.Add(permisos[3]);
                    admin.Permisos.Add(permisos[4]);
                    admin.Permisos.Add(permisos[5]);


                    familias.Add(admin);
                    GuardarFamilia();
                }
            }
        }



    }
}
