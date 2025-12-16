using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    //Clase creada con el fin de poblar la base de datos con datos de prueba.
    public static class PoblarBaseDatos
    {
        private static bool poblada = false;

        //PRE: ---
        //POST: pobla la base de datos con datos de prueba si no ha sido inicializada previamente.
        public static void Inicializar()
        {
            if (poblada) return;
            PoblarPersonal();
            PoblarUsuarios();
            PoblarDocumentosYEjemplares();
            poblada = true;
        }

        //PRE: ---
        //POST: crea personal de sala y adquisiciones de prueba. DEBE SER PRIMERO porque Ejemplar necesita un responsable.
        private static void PoblarPersonal()
        {
            // Personal de Sala 1: dni=33333333E, contraseña=sala123, NSS=100001
            PersonalSala personalSala1 = new PersonalSala("Luis", "33333333E", 100001);
            personalSala1.SetHashContraseña(Hash.GetHash("sala123"));
            Persistencia.AltaPersonalSala(personalSala1);

            // Personal de Sala 2: dni=44444444F, contraseña=sala456, NSS=100002
            PersonalSala personalSala2 = new PersonalSala("Santiago", "44444444F", 100002);
            personalSala2.SetHashContraseña(Hash.GetHash("sala456"));
            Persistencia.AltaPersonalSala(personalSala2);

            // Personal de Adquisiciones 1: dni=55555555G, contraseña=adq123, NSS=200001
            PersonalAdquisiciones personalAdq1 = new PersonalAdquisiciones("Ana", "55555555G", 200001);
            personalAdq1.SetHashContraseña(Hash.GetHash("adq123"));
            Persistencia.AltaPersonalAdquisiciones(personalAdq1);

            // Personal de Adquisiciones 2: dni=66666666H, contraseña=adq456, NSS=200002
            PersonalAdquisiciones personalAdq2 = new PersonalAdquisiciones("Javier", "66666666H", 200002);
            personalAdq2.SetHashContraseña(Hash.GetHash("adq456"));
            Persistencia.AltaPersonalAdquisiciones(personalAdq2);

            // Personal de Adquisiciones 2: dni=66666666H, contraseña=adq456, NSS=200002
            PersonalAdquisiciones personalAdq3 = new PersonalAdquisiciones("Alberto", "77777777H", 200003);
            personalAdq2.SetHashContraseña(Hash.GetHash("adq456"));
            Persistencia.AltaPersonalAdquisiciones(personalAdq3);
        }

        //PRE: ---
        //POST: crea usuarios de prueba con contraseñas hash.
        private static void PoblarUsuarios()
        {
            // Usuario 1: dni=12345678A, contraseña=juan321
            Usuario usuario1 = new Usuario("Juan", "12345678A");
            usuario1.SetHashContraseña(Hash.GetHash("juan321"));
            Persistencia.AltaUsuario(usuario1);

            // Usuario 2: dni=87654321B, contraseña=maria123
            Usuario usuario2 = new Usuario("Maria", "87654321B");
            usuario2.SetHashContraseña(Hash.GetHash("maria123"));
            Persistencia.AltaUsuario(usuario2);

            // Usuario 3: dni=11111111C, contraseña=carl444
            Usuario usuario3 = new Usuario("Carlos ", "11111111C");
            usuario3.SetHashContraseña(Hash.GetHash("carl444"));
            Persistencia.AltaUsuario(usuario3);

            // Usuario 4 (Sancionado): dni=22222222D, contraseña=sancionado
            Usuario usuario4 = new Usuario("Lucas", "22222222D");
            usuario4.SetHashContraseña(Hash.GetHash("sancionado"));
            usuario4.Sancionar();
            Persistencia.AltaUsuario(usuario4);

            // Usuario 5: dni=77777777H, contraseña=adq456
            Usuario usuario5 = new Usuario("Alberto", "77777777H");
            Persistencia.AltaUsuario(usuario5);
        }

        //PRE: debe haberse ejecutado PoblarPersonal() antes.
        //POST: crea documentos y ejemplares de prueba.
        private static void PoblarDocumentosYEjemplares()
        {
            PersonalAdquisiciones responsable1 = Persistencia.GetPersonalAdquisiciones("55555555G");
            PersonalAdquisiciones responsable2 = Persistencia.GetPersonalAdquisiciones("66666666H");

            // Libro 1: El Quijote
            Libro libro1 = new Libro(
                "Don Quijote de la Mancha",
                "Miguel de Cervantes",
                "978-84-376-0494-7",
                "Cátedra",
                1605
            );
            Persistencia.AltaDocumento(libro1);
            Ejemplar ejemplar1 = new Ejemplar("Estantería A-12", true, libro1, responsable1);
            Ejemplar ejemplar2 = new Ejemplar("Estantería A-13", true, libro1, responsable1);
            Ejemplar ejemplar3 = new Ejemplar("Estantería A-14", true, libro1, responsable2);
            Persistencia.AltaEjemplar(ejemplar1);
            Persistencia.AltaEjemplar(ejemplar2);
            Persistencia.AltaEjemplar(ejemplar3);

            // Libro 2: Cien años de soledad
            Libro libro2 = new Libro(
                "Cien años de soledad",
                "Gabriel García Márquez",
                "978-84-204-8246-8",
                "Sudamericana",
                1967
            );
            Persistencia.AltaDocumento(libro2);
            Ejemplar ejemplar4 = new Ejemplar("Estantería B-05", true, libro2, responsable2);
            Ejemplar ejemplar5 = new Ejemplar("Estantería B-06", false, libro2, responsable2); 
            Persistencia.AltaEjemplar(ejemplar4);
            Persistencia.AltaEjemplar(ejemplar5);

            // Audiolibro 1: 1984
            Audiolibro audio1 = new Audiolibro(
                "1984",
                "George Orwell",
                "978-84-666-1146-8",
                "Debolsillo",
                1949
            );
            audio1.Formato = FormatoAudio.mp3;
            audio1.DuracionSegundos = 4329;
            Persistencia.AltaDocumento(audio1);
            Ejemplar ejemplar6 = new Ejemplar("Sección Digital - Sala 1", true, audio1, responsable1);
            Ejemplar ejemplar7 = new Ejemplar("Sección Digital - Sala 2", true, audio1, responsable1);
            Ejemplar ejemplar8 = new Ejemplar("Sección Digital - Sala 3", false, audio1, responsable1);
            Persistencia.AltaEjemplar(ejemplar6);
            Persistencia.AltaEjemplar(ejemplar7);
            Persistencia.AltaEjemplar(ejemplar8);
            

            // Libro 3: El principito
            Libro libro3 = new Libro(
                "El Principito",
                "Antoine de Saint-Exupéry",
                "978-84-9838-499-1",
                "Salamandra",
                1943
            );
            Persistencia.AltaDocumento(libro3);
            Ejemplar ejemplar9 = new Ejemplar("Estantería C-20", true, libro3, responsable2);
            Ejemplar ejemplar10 = new Ejemplar("Estantería C-21", false, libro3, responsable1);
            Ejemplar ejemplar11 = new Ejemplar("Estantería C-22", true, libro3, responsable1);
            Persistencia.AltaEjemplar(ejemplar9);
            Persistencia.AltaEjemplar(ejemplar10);
            Persistencia.AltaEjemplar(ejemplar11);
        }
    }
}
