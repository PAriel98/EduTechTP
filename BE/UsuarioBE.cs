using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace EduTech
{
    public class UsuarioBE
    {
        private string _usuario;

        public string USUARIO
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }   


        private string _contrasena;

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
