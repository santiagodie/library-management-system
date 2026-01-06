using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public static class Hash
    {
        //PRE: contraseña no puede ser nula.
        //POST: devuelve una cadena que representa el hash SHA256 de la contraseña en formato hexadecimal.
        public static string GetHash(string contraseña)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] input = Encoding.UTF8.GetBytes(contraseña);
            byte[] hashBytes = sha256.ComputeHash(input);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        //PRE: longitud debe ser un entero positivo.
        //POST: devuelve una cadena de caracteres aleatorios de la longitud especificada utilizando caracteres alfanuméricos y especiales.
        public static string CrearPassword(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+";
            StringBuilder s = new StringBuilder();

            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            byte[] buffer = new byte[4];

            while (s.Length < longitud)
            {
                rng.GetBytes(buffer);
                uint n = BitConverter.ToUInt32(buffer, 0);
                s.Append(caracteres[(int)(n % (uint)caracteres.Length)]);
            }


            return s.ToString();
        }
    }
}