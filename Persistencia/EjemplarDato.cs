using Microsoft.SqlServer.Server;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class EjemplarDato: Entidad
    {
        private static int NextID = 0;
        private int id;
        private string ISBN;
        private string Localización;
        private bool Estado;
        public EjemplarDato(string iSBN, string localización, bool estado)
        {
            this.id = NextID;
            NextID++;
            ISBN = iSBN;
            Localización = localización;
            Estado = estado;
        }
        public override object ObtenerClave()
        {
            return id;
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            if(nombre!="id" && nombre != "ISBN")
            {
                this.GetType().GetProperty(nombre).SetValue(this,dato);
                return true;
            }
            return false;
        }
        public override Object ObtenerDato(string nombre)
        {
            return this.GetType().GetProperty(nombre).GetValue(this);
        }
    }
}
