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
    public enum TipoListado
    {
        Vencidos,
        Activos,
        Prestamos,
        Devoluciones
    }
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

            CargarTabla(dgvVencidos,TipoListado.Vencidos);
            CargarTabla(dgvActivos, TipoListado.Activos);
            CargarTabla(dgvPrestamos, TipoListado.Prestamos);
            CargarTabla(dgvDevoluciones, TipoListado.Devoluciones);

        }

        private void CargarTabla(DataGridView dgvDestino, TipoListado tipo)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario", typeof(string));
            tabla.Columns.Add("Documento", typeof(string));
            tabla.Columns.Add("Fecha/Info", typeof(string));
            tabla.Columns.Add("Estado", typeof(string));

            List<Prestamo> listaPrestamos = new List<Prestamo>();

            switch (tipo)
            {
                case TipoListado.Vencidos:
                    listaPrestamos = gestorSala.GetPrestamosRetrasados();
                    break;
                case TipoListado.Activos:
                    listaPrestamos = gestorSala.GetPrestamosActivos();
                    break;
                case TipoListado.Prestamos:
                    listaPrestamos = gestorSala.GetUltimosPrestamos(20);
                    break;
                case TipoListado.Devoluciones:
                    listaPrestamos = gestorSala.GetUltimasDevoluciones(20);
                    break;
            }

            foreach (Prestamo p in listaPrestamos)
            {
                if (p == null) continue;

                List<Ejemplar> ejemplaresAMostrar = new List<Ejemplar>();

                switch (tipo)
                {
                    case TipoListado.Activos:
                    case TipoListado.Vencidos:
                        ejemplaresAMostrar.AddRange(p.EjemplaresPrestados);
                        break;

                    case TipoListado.Devoluciones:
                        ejemplaresAMostrar.AddRange(p.EjemplaresDevueltos);
                        break;

                    case TipoListado.Prestamos:
                        ejemplaresAMostrar.AddRange(p.EjemplaresPrestados);
                        ejemplaresAMostrar.AddRange(p.EjemplaresDevueltos);
                        break;
                }

                if (ejemplaresAMostrar.Count == 0) continue;

                DateTime fechaLimite = p.FechaVencimiento;
                if (tipo == TipoListado.Devoluciones) fechaLimite = p.FechaInicio;

                foreach (Ejemplar ej in ejemplaresAMostrar)
                {
                    string colFecha = "";
                    string colEstado = "";

                    switch (tipo)
                    {
                        case TipoListado.Vencidos:
                            TimeSpan retraso = DateTime.Today - fechaLimite;
                            colFecha = fechaLimite.ToShortDateString();
                            colEstado = retraso.Days + " días de retraso";
                            break;

                        case TipoListado.Activos:
                            colFecha = fechaLimite.ToShortDateString();
                            colEstado = "En curso";
                            break;

                        case TipoListado.Prestamos:
                            colFecha = (p.FechaInicio.Date == DateTime.Today)
                                        ? p.FechaInicio.ToShortTimeString()
                                        : p.FechaInicio.ToShortDateString();
                            bool yaDevuelto = p.EjemplaresDevueltos.Contains(ej);
                            colEstado = yaDevuelto ? "Devuelto" : "Prestado";
                            break;

                        case TipoListado.Devoluciones:
                            colFecha = "---";
                            colEstado = "Devuelto";
                            break;
                    }

                    tabla.Rows.Add(p.Usuario.Nombre, ej.Documento.Titulo, colFecha, colEstado);
                }
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvDestino.DataSource = bs;
            dgvDestino.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

