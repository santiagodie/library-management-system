using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class PersonaDato : Entidad
    {
        private static int NextID=0;
        private int id;
        private string Nombre;
        private string DNI;
        private string Contraseña;
        public PersonaDato(string Contraseña, string Nombre, string DNI)
        {
            this.id = NextID;
            NextID++;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;
            this.DNI = DNI;
        }
        public override string ObtenerClave()
        {
            return id.ToString();
        }
        public override bool ModificarDato(string nombre, Object dato)
        {
            switch (nombre)
            {
                case "Contraseña":
                    Contraseña = dato as String;
                    return true;
                case "Nombre":
                    Nombre = dato as String;
                    return true;
                default: return false;
            }
        }
        public override Object ObtenerDato(string nombre)
        {
            switch (nombre)
            {
                case "id":
                    return id.ToString();
                case "Contraseña":
                    return Contraseña;
                case "Nombre":
                    return Nombre;
                case "DNI":
                    return DNI;
            }
        }

    }
}
