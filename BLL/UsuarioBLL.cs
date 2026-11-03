using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BE;
using SEGURIDAD;


namespace EduTech
{
    public class UsuarioBLL
    {

        private UsuarioMapper _usuarioMapper = new UsuarioMapper();
        private Encriptacion _encriptacionSEG = new Encriptacion();

        public int Alta(UsuarioBE usuario)
        {
            var dni = 0;
            usuario.Contrasena = _encriptacionSEG.EncriptarConSHA256(usuario.Nombre + usuario.Apellido);
            try
            {
                dni = _usuarioMapper.Alta(usuario);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    string error = ex.Message.ToLower();

                    if (error.Contains("login"))
                    {
                        throw new Exception("Ya existe un usuario con ese Login.");
                    }

                    if (error.Contains("dni"))
                    {
                        throw new Exception("Ya existe un usuario con ese DNI.");
                    }

                    throw new Exception("Ya existe un usuario con los datos ingresados.");
                    throw;
                }
            }
            return dni;
        }
       
        public int Modificar(UsuarioBE usuario)
        {
            var filasAfectadas = 0;
            try
            {
                filasAfectadas = _usuarioMapper.Modificar(usuario);

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    string error = ex.Message.ToLower();

                    if (error.Contains("login"))
                    {
                        throw new Exception("Ya existe un usuario con ese Login.");
                    }

                    if (error.Contains("dni"))
                    {
                        throw new Exception("Ya existe un usuario con ese DNI.");
                    }

                    throw new Exception("Error al modificar Datos");
                    throw;
                }
            }
            return filasAfectadas;
        }

        public UsuarioBE Buscar_por_DNI(string dni)
        {
            UsuarioBE persona = null;
            try
            {
                persona = _usuarioMapper.BuscarUsuario(dni: dni);
            }
            catch (Exception ex)
            {
                throw;
            }
            return persona;
        }

        public UsuarioBE Login(string login, string contrasena)
        {
            try
            {
                UsuarioBE usuario = _usuarioMapper.BuscarUsuario(login: login);

                if (usuario == null)
                {
                    throw new Exception("Usuario no registrado.");
                }
                string contrasenaHasheada = _encriptacionSEG.EncriptarConSHA256(contrasena);

                if (usuario.Contrasena == contrasenaHasheada)
                {
                    SessionManager.GetInstancia().Login(usuario);
                    return usuario;
                }
                else
                {
                    throw new Exception("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Logout()
        {
            try
            {
                UsuarioBE usuarioActual = SessionManager.GetInstancia().UsuarioLogueado;

                if (usuarioActual == null) {
                    throw new Exception("No hay un usuario logueado.");
                }

                SessionManager.GetInstancia().Logout();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<UsuarioBE> TraerTodosUsuarios()
        {
            try
            {
                return _usuarioMapper.TraerTodosUsuarios();
            }
            catch (Exception ex)
            {
                throw;
            }
        }      
    }
}
