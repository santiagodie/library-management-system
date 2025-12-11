using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class Persistencia
    {
        // ------------- GESTIÓN DE USUARIOS 

        public static bool ExisteUsuario(string dni)
        {
            return BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", dni) != null;
        }

        public static bool AltaUsuario(Usuario usuario)
        {
            UsuarioDato ud = Transformer.ToUsuarioDato(usuario);
            return BaseDatos.BaseDatos.AñadirFila("UsuarioTabla", ud);
        }

        public static bool BajaUsuario(Usuario usuario)
        {
            return BaseDatos.BaseDatos.BorrarFila("UsuarioTabla", usuario.Dni);
        }

        public static Usuario GetUsuario(string dni)
        {
            UsuarioDato ud = BaseDatos.BaseDatos.ObtenerDatos("UsuarioTabla", dni) as UsuarioDato;
            if (ud == null) return null;
            return Transformer.ToUsuario(ud);
        }

        public static List<Usuario> GetListaUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Entidad> datos = BaseDatos.BaseDatos.ObtenerTodos("UsuarioTabla");

            foreach (Entidad e in datos)
            {
                UsuarioDato ud = e as UsuarioDato;
                if (ud != null)
                {
                    usuarios.Add(Transformer.ToUsuario(ud));
                }
            }
            return usuarios;
        }
    }   
}
