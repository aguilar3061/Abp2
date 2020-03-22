using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGridViewEventos : Form
    {
        public FormGridViewEventos()
        {
            InitializeComponent();
        }

        private void FormGridViewEventos_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = BD.ComunitatsORM.SelectAllComunitats();
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllHotelesPorComunidad((int)comboBoxComunitats.SelectedValue);
        }

        private void comboBoxComunitats_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllHotelesPorComunidad((int)comboBoxComunitats.SelectedValue);
        }
    }
}
