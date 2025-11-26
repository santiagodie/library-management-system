using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia.Datos
{
    public class UsuarioDatos
    {
        private readonly Tabla _tablaUsuarios;

        public UsuarioDatos(Tabla tablaUsuarios)
        {
            _tablaUsuarios = tablaUsuarios;
        }

        public bool AltaUsuario(Usuario usuario)
        {
            return _tablaUsuarios.AñadirFila(usuario);
        }

        public Usuario ObtenerPorDni(string dni)
        {
            var entidad = _tablaUsuarios.ObtenerDatos(dni);
            return entidad as Usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            var usuarios = new List<Usuario>();

            // Recorrer todas las entidades de la tabla
            foreach (var entidad in _tablaUsuarios)
            {
                if (entidad is Usuario usuario)
                {
                    if (usuario.GetEstado() == EstadoUsuario.Activo)
                    {
                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }

        public bool ActualizarUsuario(string dni, string columna, object dato)
        {
            return _tablaUsuarios.ModificarFila(dni, columna, dato);
        }

        public bool BajaUsuario(string dni)
        {
            // Cambiar el estado del usuario a Inactivo (baja lógica)
            return _tablaUsuarios.ModificarFila(dni, "Estado", EstadoUsuario.Sancionado);
        }

        public bool EliminarUsuario(string dni)
        {
            return _tablaUsuarios.BorrarFila(dni);
        }

        public bool ExisteUsuario(string dni)
        {
            return ObtenerPorDni(dni) != null;
        }

    }
}