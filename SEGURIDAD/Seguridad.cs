using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduTech
{
    public class Seguridad
    {
        private static readonly string clave = ""; 
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456"); // 16 bytes


        public static void Guardar(string ruta, string contenido, bool append = true)
        {
            try
            {
               
                if (File.Exists(ruta))
                {
                    File.SetAttributes(ruta, FileAttributes.Normal);
                }

               
                string cifrado = Encriptar(contenido);
 
                using (StreamWriter sw = new StreamWriter(ruta, append))
                {
                    sw.WriteLine(cifrado);
                }

               
                if (File.Exists(ruta))
                {
                    File.SetAttributes(ruta, FileAttributes.Hidden);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar archivo seguro", ex);
            }
        }


        public static string[] Leer(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                    return new string[0];

                var lineas = File.ReadAllLines(ruta);
                for (int i = 0; i < lineas.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        lineas[i] = Desencriptar(lineas[i]);
                    }
                }
                return lineas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer archivo seguro", ex);
            }
        }

        
        private static string Encriptar(string textoPlano)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave.PadRight(32).Substring(0, 32));
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] buffer = Encoding.UTF8.GetBytes(textoPlano);

                return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }

        
        private static string Desencriptar(string textoCifrado)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(clave.PadRight(32).Substring(0, 32));
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor();
                byte[] buffer = Convert.FromBase64String(textoCifrado);

                return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }
    }
}
