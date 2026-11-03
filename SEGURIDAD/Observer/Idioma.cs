using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace EduTech.Observer
{
    public class Idioma
    {
        public string Nombre { get; set; }
        public Dictionary<string, string> Traducciones { get; set; }

        public Idioma(string nombre, Dictionary<string, string> traducciones)
        {
            Nombre = nombre;
            Traducciones = traducciones;
        }

        public string Traducir(string clave)
        {
            if (Traducciones != null && Traducciones.ContainsKey(clave))
            {
                return Traducciones[clave];
            }

            return string.Empty;
        }

        public static List<string> ObtenerNombres()
        {
            return new List<string> { "Español", "English", "Deutsch" };
        }

        public static Idioma CrearPorNombre(string nombre)
        {
            if (nombre == "English")
            {
                return CargarDesdeJson("en-US.json", "English");
            }

            if (nombre == "Deutsch")
            {
                return CargarDesdeJson("de-DE.json", "Deutsch");
            }

            return CargarDesdeJson("es-AR.json", "Español");
        }

        public static Idioma CrearEspanol()
        {
            return CrearPorNombre("Español");
        }

        private static Idioma CargarDesdeJson(string archivo, string nombrePorDefecto)
        {
            string ruta = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "IDIOMAS", archivo);

            if (!File.Exists(ruta))
            {
                return new Idioma(nombrePorDefecto, new Dictionary<string, string>());
            }

            string json = File.ReadAllText(ruta);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Dictionary<string, object> datos = serializer.Deserialize<Dictionary<string, object>>(json);

            string nombre = nombrePorDefecto;
            if (datos.ContainsKey("Nombre"))
            {
                nombre = datos["Nombre"].ToString();
            }

            Dictionary<string, string> traducciones = new Dictionary<string, string>();
            Dictionary<string, object> traduccionesJson = datos["Traducciones"] as Dictionary<string, object>;

            if (traduccionesJson != null)
            {
                foreach (KeyValuePair<string, object> traduccion in traduccionesJson)
                {
                    traducciones.Add(traduccion.Key, traduccion.Value.ToString());
                }
            }

            return new Idioma(nombre, traducciones);
        }
    }
}
