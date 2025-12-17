using ModeloDominio;
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
    public partial class FormPersonal : Form
    {
        public Personal personal;
        public FormPersonal(Personal personal, Rol rol)
        {
            InitializeComponent();
            this.personal= personal;
            if (rol == Rol.PersonalSala)
            {
                Tab.TabPages.Remove(Adquisiciones);
            }
            else
            {
                Tab.TabPages.Remove(Sala);
            }
        }
    }
}
