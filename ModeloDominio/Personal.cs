using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Personal:Persona
    {
        public int NSS { get; private set; }
        public Personal(string nombre, string dni,int NSS): base( nombre, dni)
        {
            this.NSS = NSS;
        }
        public void AltaUsuario(Usuario usuario)
        {

        }
        public void BajaUsuario(Usuario usuario)
        {

        }
        public Usuario[] getListaUsuarios()
        {
            return null;
        }
        public Usuario ConsultarUsuario(string id)
        {
            return null;
        }
        public Prestamo[] GetPrestRetrasados(Usuario usuario)
        {
            return null;
        }
        public Ejemplar[] GetEjemplaresPrest(Usuario usuario)
        {
            return null;
        }
    }
}
