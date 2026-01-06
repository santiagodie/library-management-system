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
        private BindingSource source;
        public event Action<Usuario> MostrarUsuario;
        public UC_ListadoUsuarios()
        {
            InitializeComponent();
            GestorUsuarios gestor=new GestorUsuarios();
            users=gestor.GetListaUsuarios();
            source=new BindingSource();
            source.DataSource = users;
            Lista.DataSource = source;
        }

        private void Lista_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PropertyInfo prop = typeof(Usuario).GetProperty(Lista.Columns[e.ColumnIndex].DataPropertyName);
            users.Sort((a,b) =>
            {
                IComparable valA=prop.GetValue(a) as IComparable;
                IComparable valB=prop.GetValue(b) as IComparable;
                return valA.CompareTo(valB);
            });
            source.ResetBindings(false);
        }

        private void Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MostrarUsuario.Invoke(Lista.Rows[e.RowIndex].DataBoundItem as Usuario);
            }
        }
    }
}
