using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BaseDatos;
using ModeloDominio;

    namespace Persistencia.Contexto
    {
        /// <summary>
        /// Contexto centralizado para gestionar todas las tablas del sistema de biblioteca.
        /// Actúa como punto único de acceso a todas las colecciones de datos.
        /// </summary>
        public class BibliotecaContexto
        {

            /// <summary>
            /// Tabla que contiene todos los usuarios de la biblioteca
            /// </summary>
            public Tabla TablaUsuarios { get; private set; }

            /// <summary>
            /// Tabla que contiene todos los documentos (LibrosPapel y Audiolibros)
            /// </summary>
            public Tabla TablaDocumentos { get; private set; }

            /// <summary>
            /// Tabla que contiene todos los ejemplares de los documentos
            /// </summary>
            public Tabla TablaEjemplares { get; private set; }

            /// <summary>
            /// Tabla que contiene todos los préstamos realizados
            /// </summary>
            public Tabla TablaPrestamos { get; private set; }

            /// <summary>
            /// Tabla que contiene todo el personal de la biblioteca
            /// </summary>
            public Tabla TablaPersonal { get; private set; }


            /// <summary>
            /// Constructor que inicializa todas las tablas vacías
            /// </summary>
            public BibliotecaContexto()
            {
                TablaUsuarios = new Tabla();
                TablaDocumentos = new Tabla();
                TablaEjemplares = new Tabla();
                TablaPrestamos = new Tabla();
                TablaPersonal = new Tabla();
            }

            /// <summary>
            /// Limpia todas las tablas (útil para testing o reinicio)
            /// </summary>
            public void LimpiarTodasLasTablas()
            {
                TablaUsuarios = new Tabla();
                TablaDocumentos = new Tabla();
                TablaEjemplares = new Tabla();
                TablaPrestamos = new Tabla();
                TablaPersonal = new Tabla();
            }

            /// <summary>
            /// Obtiene estadísticas generales del sistema
            /// </summary>
            public EstadisticasSistema ObtenerEstadisticas()
            {
                return new EstadisticasSistema
                {
                    TotalUsuarios = TablaUsuarios.Count,
                    TotalDocumentos = TablaDocumentos.Count,
                    TotalEjemplares = TablaEjemplares.Count,
                    TotalPrestamos = TablaPrestamos.Count,
                    TotalPersonal = TablaPersonal.Count
                };
            }

            /// <summary>
            /// Verifica si el sistema está vacío
            /// </summary>
            public bool EstaVacio()
            {
                return TablaUsuarios.Count == 0 &&
                       TablaDocumentos.Count == 0 &&
                       TablaEjemplares.Count == 0 &&
                       TablaPrestamos.Count == 0 &&
                       TablaPersonal.Count == 0;
            }
        }

        /// <summary>
        /// Clase auxiliar para almacenar estadísticas del sistema
        /// </summary>
        public class EstadisticasSistema
        {
            public int TotalUsuarios { get; set; }
            public int TotalDocumentos { get; set; }
            public int TotalEjemplares { get; set; }
            public int TotalPrestamos { get; set; }
            public int TotalPersonal { get; set; }


        }
    }

