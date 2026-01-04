using ModeloDominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class UC_Inicio : UserControl
    {
        GestorSala gestorSala;
        public UC_Inicio()
        {
            InitializeComponent();
            gestorSala = new GestorSala();
            CargarDatos();
        }

        private void CargarDatos()
        {
            int numVencidos = gestorSala.GetPrestamosRetrasados().Count;
            int numHoy = 0;
            int numSala = 0;

            lbNVencidos.Text = numVencidos.ToString();
            lbNHoy.Text = numHoy.ToString();
            lbNSala.Text = numSala.ToString();

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario", typeof(string));
            tabla.Columns.Add("Documento", typeof(string));
            tabla.Columns.Add("Fecha Límite", typeof(DateTime));
            tabla.Columns.Add("Estado", typeof(string));

            List<Prestamo> listaVencidos = gestorSala.GetPrestamosRetrasados();

            foreach (Prestamo p in listaVencidos)
            {
                foreach (Ejemplar ej in p.EjemplaresPrestados)
                {
                    DateTime fechaLimiteItem;

                    if (ej.Documento is Libro)
                    {
                        fechaLimiteItem = p.FechaFin[0];
                    }
                    else
                    {
                        fechaLimiteItem = p.FechaFin[1];
                    }

                    if (fechaLimiteItem < DateTime.Today && fechaLimiteItem != DateTime.MinValue)
                    {
                        TimeSpan diferencia = DateTime.Today - fechaLimiteItem;
                        string textoRetraso = diferencia.Days + " días de retraso";

                        tabla.Rows.Add(p.Usuario.Nombre, ej.Documento.Titulo, fechaLimiteItem.ToShortDateString(), textoRetraso);
                    }
                }
            }

                dgvPrestamos.DataSource = tabla;
            }
        }
    }

