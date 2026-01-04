using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    // Clase creada con el fin de poblar la base de datos con datos de prueba.
    public static class PoblarBaseDatos
    {
        private static bool poblada = false;

        // PRE: ---
        // POST: puebla la base de datos con datos de prueba si no ha sido inicializada previamente.
        public static void Inicializar()
        {
            if (poblada) return;
            PoblarPersonal();
            PoblarUsuarios();
            PoblarDocumentosYEjemplares();
            PoblarPrestamos();
            poblada = true;
        }

        // PRE: ---
        // POST: crea personal de sala y adquisiciones de prueba. DEBE SER PRIMERO porque Ejemplar necesita un responsable.
        private static void PoblarPersonal()
        {
            // Personal de Sala 1: dni=33333333P
            PersonalSala personalSala1 = new PersonalSala("Luis", "33333333P", 100001);
            personalSala1.SetHashContraseña(Hash.GetHash("sala123"));
            Persistencia.Instancia.AltaPersonalSala(personalSala1);

            // Personal de Sala 2: dni=44444444A
            PersonalSala personalSala2 = new PersonalSala("Santiago", "44444444A", 100002);
            personalSala2.SetHashContraseña(Hash.GetHash("sala456"));
            Persistencia.Instancia.AltaPersonalSala(personalSala2);

            // Personal de Adquisiciones 1: dni=55555555K
            PersonalAdquisiciones personalAdq1 = new PersonalAdquisiciones("Ana", "55555555K", 200001);
            personalAdq1.SetHashContraseña(Hash.GetHash("adq123"));
            Persistencia.Instancia.AltaPersonalAdquisiciones(personalAdq1);

            // Personal de Adquisiciones 2: dni=66666666Q
            PersonalAdquisiciones personalAdq2 = new PersonalAdquisiciones("Javier", "66666666Q", 200002);
            personalAdq2.SetHashContraseña(Hash.GetHash("adq456"));
            Persistencia.Instancia.AltaPersonalAdquisiciones(personalAdq2);

            // Personal de Adquisiciones 3: dni=77777777B
            PersonalAdquisiciones personalAdq3 = new PersonalAdquisiciones("Alberto", "77777777B", 200003);
            personalAdq3.SetHashContraseña(Hash.GetHash("adq789"));
            Persistencia.Instancia.AltaPersonalAdquisiciones(personalAdq3);
        }

        // PRE: ---
        // POST: crea usuarios de prueba con contraseñas hash.
        private static void PoblarUsuarios()
        {
            // Usuario 1: dni=12345678Z
            Usuario usuario1 = new Usuario("Juan", "12345678Z");
            usuario1.SetHashContraseña(Hash.GetHash("juan321"));
            Persistencia.Instancia.AltaUsuario(usuario1);

            // Usuario 2: dni=87654321X
            Usuario usuario2 = new Usuario("Maria", "87654321X");
            usuario2.SetHashContraseña(Hash.GetHash("maria123"));
            Persistencia.Instancia.AltaUsuario(usuario2);

            // Usuario 3: dni=11111111H
            Usuario usuario3 = new Usuario("Carlos ", "11111111H");
            usuario3.SetHashContraseña(Hash.GetHash("carl444"));
            Persistencia.Instancia.AltaUsuario(usuario3);

            // Usuario 4 (Sancionado): dni=22222222J
            Usuario usuario4 = new Usuario("Lucas", "22222222J");
            usuario4.SetHashContraseña(Hash.GetHash("sancionado"));
            usuario4.Sancionar();
            Persistencia.Instancia.AltaUsuario(usuario4);

            // Usuario 5: dni=77777777B (Coincide con Adquisiciones 3 -> Rol Doble)
            Usuario usuario5 = new Usuario("Alberto", "77777777B");
            usuario5.SetHashContraseña(Hash.GetHash("adq789")); // Misma pass para no liar
            Persistencia.Instancia.AltaUsuario(usuario5);
        }

        // PRE: deben haberse ejecutado PoblarPersonal() antes.
        // POST: crea documentos y ejemplares de prueba.
        private static void PoblarDocumentosYEjemplares()
        {
            // CORREGIDO: Ahora usamos los DNIS válidos (K y Q)
            PersonalAdquisiciones responsable1 = Persistencia.Instancia.GetPersonalAdquisiciones("55555555K");
            PersonalAdquisiciones responsable2 = Persistencia.Instancia.GetPersonalAdquisiciones("66666666Q");

            // Libro 1: El Quijote
            Libro libro1 = new Libro(
                "Don Quijote de la Mancha",
                "Miguel de Cervantes",
                "978-84-376-0494-7",
                "Cátedra",
                1605
            );
            Persistencia.Instancia.AltaDocumento(libro1);
            Ejemplar ejemplar1 = new Ejemplar("Estantería A-12", true, libro1, responsable1);
            Ejemplar ejemplar2 = new Ejemplar("Estantería A-13", true, libro1, responsable1);
            Ejemplar ejemplar3 = new Ejemplar("Estantería A-14", true, libro1, responsable2);
            Persistencia.Instancia.AltaEjemplar(ejemplar1);
            Persistencia.Instancia.AltaEjemplar(ejemplar2);
            Persistencia.Instancia.AltaEjemplar(ejemplar3);

            // Libro 2: Cien años de soledad
            Libro libro2 = new Libro(
                "Cien años de soledad",
                "Gabriel García Márquez",
                "978-84-204-8246-8",
                "Sudamericana",
                1967
            );
            Persistencia.Instancia.AltaDocumento(libro2);
            Ejemplar ejemplar4 = new Ejemplar("Estantería B-05", true, libro2, responsable2);
            Ejemplar ejemplar5 = new Ejemplar("Estantería B-06", false, libro2, responsable2);
            Persistencia.Instancia.AltaEjemplar(ejemplar4);
            Persistencia.Instancia.AltaEjemplar(ejemplar5);

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
            Persistencia.Instancia.AltaDocumento(audio1);
            Ejemplar ejemplar6 = new Ejemplar("Sección Digital - Sala 1", true, audio1, responsable1);
            Ejemplar ejemplar7 = new Ejemplar("Sección Digital - Sala 2", true, audio1, responsable1);
            Ejemplar ejemplar8 = new Ejemplar("Sección Digital - Sala 3", false, audio1, responsable1);
            Persistencia.Instancia.AltaEjemplar(ejemplar6);
            Persistencia.Instancia.AltaEjemplar(ejemplar7);
            Persistencia.Instancia.AltaEjemplar(ejemplar8);

            // Libro 3: El principito
            Libro libro3 = new Libro(
                "El Principito",
                "Antoine de Saint-Exupéry",
                "978-84-9838-499-1",
                "Salamandra",
                1943
            );
            Persistencia.Instancia.AltaDocumento(libro3);
            Ejemplar ejemplar9 = new Ejemplar("Estantería C-20", true, libro3, responsable2);
            Ejemplar ejemplar10 = new Ejemplar("Estantería C-21", false, libro3, responsable1);
            Ejemplar ejemplar11 = new Ejemplar("Estantería C-22", true, libro3, responsable1);
            Persistencia.Instancia.AltaEjemplar(ejemplar9);
            Persistencia.Instancia.AltaEjemplar(ejemplar10);
            Persistencia.Instancia.AltaEjemplar(ejemplar11);
        }

        // PRE: deben haberse ejecutado PoblarPersonal(), PoblarUsuarios() y PoblarDocumentosYEjemplares() antes.
        // POST: crea préstamos de prueba con diferentes estados (activos y finalizados).
        private static void PoblarPrestamos()
        {
            Usuario usuario1 = Persistencia.Instancia.GetUsuario("12345678Z");
            Usuario usuario2 = Persistencia.Instancia.GetUsuario("87654321X");
            PersonalSala responsableSala1 = Persistencia.Instancia.GetPersonalSala("33333333P");
            PersonalSala responsableSala2 = Persistencia.Instancia.GetPersonalSala("44444444A");

            // Documentos
            Documento quijote = Persistencia.Instancia.GetDocumento("978-84-376-0494-7");
            Documento cienAnos = Persistencia.Instancia.GetDocumento("978-84-204-8246-8");
            Documento audio1984 = Persistencia.Instancia.GetDocumento("978-84-666-1146-8");
            Documento principito = Persistencia.Instancia.GetDocumento("978-84-9838-499-1");

            // Ejemplares
            List<Ejemplar> ejemplaresQuijote = Persistencia.Instancia.GetEjemplares(quijote);
            List<Ejemplar> ejemplaresCienAnos = Persistencia.Instancia.GetEjemplares(cienAnos);
            List<Ejemplar> ejemplaresAudio = Persistencia.Instancia.GetEjemplares(audio1984);
            List<Ejemplar> ejemplaresPrincipito = Persistencia.Instancia.GetEjemplares(principito);

            // Prestamo 1: JUAN (2 libros)
            List<Ejemplar> prestamo1Ejemplares = new List<Ejemplar> { ejemplaresQuijote[0], ejemplaresCienAnos[0] };
            DateTime[] fechaFin1 = new DateTime[2];
            fechaFin1[0] = DateTime.Today.AddDays(15);
            fechaFin1[1] = DateTime.MinValue;
            Prestamo prestamo1 = new Prestamo(fechaFin1, usuario1, prestamo1Ejemplares, responsableSala1);
            Persistencia.Instancia.AltaPrestamo(prestamo1);
            Persistencia.Instancia.ActualizarDisponibilidad(prestamo1Ejemplares);

            // Prestamo 2: MARIA (mixto)
            List<Ejemplar> prestamo2Ejemplares = new List<Ejemplar> { ejemplaresPrincipito[0], ejemplaresAudio[0] };
            DateTime[] fechaFin2 = new DateTime[2];
            fechaFin2[0] = DateTime.Today.AddDays(15);
            fechaFin2[1] = DateTime.Today.AddDays(10);
            Prestamo prestamo2 = new Prestamo(fechaFin2, usuario2, prestamo2Ejemplares, responsableSala2);
            Persistencia.Instancia.AltaPrestamo(prestamo2);
            Persistencia.Instancia.ActualizarDisponibilidad(prestamo2Ejemplares);

            // Prestamo 3: JUAN (Finalizado)
            List<Ejemplar> prestamo3Ejemplares = new List<Ejemplar> { ejemplaresQuijote[2] };
            DateTime[] fechaFin3 = new DateTime[2];
            fechaFin3[0] = DateTime.Today.AddDays(-10);
            fechaFin3[1] = DateTime.MinValue;
            Prestamo prestamo3 = new Prestamo(fechaFin3, usuario1, prestamo3Ejemplares, responsableSala2);
            prestamo3.FechaInicio = DateTime.Today.AddDays(-25);
            // Simular devolución:
            prestamo3.DevolverEjemplar(ejemplaresQuijote[2]);
            ejemplaresQuijote[2].Disponible = true;
            Persistencia.Instancia.AltaPrestamo(prestamo3);
            Persistencia.Instancia.ActualizarEjemplar(ejemplaresQuijote[2]);

            // Prestamo 4: MARIA (Próximo a vencer / Retrasado)
            List<Ejemplar> prestamo4Ejemplares = new List<Ejemplar> { ejemplaresCienAnos[1] };
            DateTime[] fechaFin4 = new DateTime[2];
            fechaFin4[0] = DateTime.Today.AddDays(2);
            fechaFin4[1] = DateTime.MinValue;
            Prestamo prestamo4 = new Prestamo(fechaFin4, usuario2, prestamo4Ejemplares, responsableSala1);
            prestamo4.FechaInicio = DateTime.Today.AddDays(-13);
            Persistencia.Instancia.AltaPrestamo(prestamo4);
            Persistencia.Instancia.ActualizarDisponibilidad(prestamo4Ejemplares);
        }
    }
}