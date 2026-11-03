using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;


namespace EduTech
{
    public class UsuarioMapper
    {
        private AccesoDAL _acceso = new AccesoDAL();
        private UsuarioBE MapearUsuario(DataRow fila)
        {
            return new UsuarioBE
            {
                Dni = fila["dni"].ToString(),
                Apellido = fila["apellido"].ToString(),
                Nombre = fila["nombre"].ToString(),
                Email = fila["email"].ToString(),
                Login = fila["login"].ToString(),
                Contrasena = fila["contrasena"].ToString(),
            };
        }
        public UsuarioBE BuscarUsuario(string dni = null, string login = null, string contrasena = null)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Usuario WHERE 1=1");
            List<SqlParameter> parametros = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(dni))
            {
                query.Append(" AND dni = @dni");
                parametros.Add(new SqlParameter("@dni", dni));
            }
            if (!string.IsNullOrEmpty(login))
            {
                query.Append(" AND login = @login");
                parametros.Add(new SqlParameter("@login", login));
            }
            if (!string.IsNullOrEmpty(contrasena))
            {
                query.Append(" AND contrasena = @contrasena");
                parametros.Add(new SqlParameter("@contrasena", contrasena));
            }

            DataTable tabla = _acceso.leer(query.ToString(), parametros.ToArray());

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return MapearUsuario(tabla.Rows[0]);
            }
            return null;
        }
        public List<UsuarioBE> BuscarUsuarios(string dni = null, string login = null, string contrasena = null)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM Usuario WHERE 1=1");
            List<SqlParameter> parametros = new List<SqlParameter>();
            List<UsuarioBE> lista = new List<UsuarioBE>();

            if (!string.IsNullOrEmpty(dni))
            {
                query.Append(" AND dni = @dni");
                parametros.Add(new SqlParameter("@dni", dni));
            }
            if (!string.IsNullOrEmpty(login))
            {
                query.Append(" AND login = @login");
                parametros.Add(new SqlParameter("@login", login));
            }
            if (!string.IsNullOrEmpty(contrasena))
            {
                query.Append(" AND contrasena = @contrasena");
                parametros.Add(new SqlParameter("@contrasena", contrasena));
            }

            DataTable tabla = _acceso.leer(query.ToString(), parametros.ToArray());

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(MapearUsuario(fila));
                }
            }
            return lista;
        }
        public List<UsuarioBE> TraerTodosUsuarios()
        {
            List<UsuarioBE> lista = new List<UsuarioBE>();
            string query = "SELECT *  FROM Usuario";

            DataTable tabla = _acceso.leer(query, null);

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(MapearUsuario(fila));
                }
            }
            return lista;
        }

        public int Alta(UsuarioBE usuario)
        {
            var dni = 0;
            string query = "INSERT INTO Usuario (dni, apellido, nombre, email, login, contrasena) VALUES (@dni, @apellido, @nombre, @email, @login, @contrasena);";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@dni", usuario.Dni),
                new SqlParameter("@apellido", usuario.Apellido),
                new SqlParameter("@nombre", usuario.Nombre),
                new SqlParameter("@email", usuario.Email),
                new SqlParameter("@login", usuario.Login),
                new SqlParameter("@contrasena", usuario.Contrasena)
            };

            object resultado = _acceso.escribir(query, parametros);
            dni = Convert.ToInt32(Convert.ToDecimal(resultado));
            return dni;
        }

        public int Modificar(UsuarioBE usuario)
        {
            var filasAfectadas = 0;
            string query = "UPDATE Usuario SET apellido = @apellido, nombre = @nombre, email = @email, login = @login WHERE dni = @dni";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@dni", usuario.Dni),
                new SqlParameter("@apellido", usuario.Apellido),
                new SqlParameter("@nombre", usuario.Nombre),
                new SqlParameter("@email", usuario.Email),
                new SqlParameter("@login", usuario.Login)
            };

            filasAfectadas = _acceso.escribir(query, parametros);
            return filasAfectadas;
        }
    }
}
