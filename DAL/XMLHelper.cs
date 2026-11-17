using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace DAL { public static class XmlHelper<T>
    {
        public static void GrabarXML(string rutaArchivo, List<T> datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                serializer.Serialize(writer, datos);
            }
        }

        public static List<T> LeerXML(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo)) return new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                return (List<T>)serializer.Deserialize(reader);
            }
        }

        public static void ModificarXML(string rutaArchivo, List<T> datosActualizados)
        {
            GrabarXML(rutaArchivo, datosActualizados);
        }
    }
}