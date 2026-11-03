using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using EduTech.Observer;



namespace EduTech
{
    public class SessionManager
    {
        private SessionManager()
        {
            // Agregado para idioma: la aplicacion arranca en espanol hasta que el usuario elija otro.
            IdiomaActual = Idioma.CrearEspanol();
        }
        private static SessionManager instancia;
        private static readonly object _lock = new object();
        private List<IObservadorIdioma> observadoresIdioma = new List<IObservadorIdioma>();

        public static SessionManager GetInstancia()
        {
            if (instancia == null)
            {
                lock (_lock)
                {
                    if (instancia == null)
                    {
                        instancia = new SessionManager();
                    }
                }
            }
            return instancia;
        }

        private UsuarioBE usuarioLogueado;

		public UsuarioBE UsuarioLogueado
        {
			get { return usuarioLogueado; }
			private set { usuarioLogueado = value; }
		}

        public Idioma IdiomaActual { get; private set; }

        public void SuscribirObservadorIdioma(IObservadorIdioma observador)
        {
            // Agregado para idioma: cada formulario se anota para enterarse de los cambios.
            if (observador != null && !observadoresIdioma.Contains(observador))
            {
                observadoresIdioma.Add(observador);
            }
        }

        public void DesuscribirObservadorIdioma(IObservadorIdioma observador)
        {
            // Agregado para idioma: al cerrar un formulario se lo saca de la lista.
            if (observador != null && observadoresIdioma.Contains(observador))
            {
                observadoresIdioma.Remove(observador);
            }
        }

        public void CambiarIdioma(Idioma idioma)
        {
            // Agregado para idioma: este metodo aplica el patron observer y avisa a todos.
            if (idioma == null)
            {
                return;
            }

            IdiomaActual = idioma;
            NotificarCambioIdioma();
        }

        private void NotificarCambioIdioma()
        {
            List<IObservadorIdioma> copiaObservadores = new List<IObservadorIdioma>(observadoresIdioma);

            foreach (IObservadorIdioma observador in copiaObservadores)
            {
                observador.ActualizarIdioma(IdiomaActual);
            }
        }

        public void Login(UsuarioBE usuario)
        {
            if (usuarioLogueado == null)
            {
                usuarioLogueado = usuario;
            }
            else
            {
                throw new Exception("Ya hay un usuario Logueado");
            }
        }

        public void Logout()
        {
            if (usuarioLogueado != null)
            {
                usuarioLogueado = null;
            }
            else
            {
                throw new Exception("No hay un usuario Logueado");
            }
        }
    }
}



    
