using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class UC_ListadoUsuarios : UserControl
    {
        private List<Usuario> users;
        public event Action<Usuario> MostrarUsuario;
        public UC_ListadoUsuarios()
        {
            InitializeComponent();
            GestorUsuarios gestor=new GestorUsuarios();
            users=gestor.GetListaUsuarios();
            Lista.DataSource = users;
        }

        private void Lista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PropertyInfo prop = typeof(Usuario).GetProperty(Lista.Columns[e.ColumnIndex].DataPropertyName);
            Lista.DataSource = users.OrderBy(u => prop.GetValue(u)).ToList();
        }

        private void Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarUsuario.Invoke(Lista.Rows[e.RowIndex].DataBoundItem as Usuario);
        }
    }
}
