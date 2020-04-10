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
    public partial class FormGirdViewUsuarios : System.Windows.Forms.Form
    {
        public FormGirdViewUsuarios()
        {
            InitializeComponent();
        }


        private void FormGirdViewUsuarios_Load(object sender, EventArgs e)
        {

            bindingSourceSocis.DataSource = BD.SociORM.SelectAllSocis();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void dataGridViewSocios_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {






        }

        private void dataGridViewSocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {




            FormEditarUsuario f2 = new FormEditarUsuario( (Socis) dataGridViewSocios.SelectedRows[0].DataBoundItem ) ;

            f2.ShowDialog();
            dataGridViewSocios.DataSource = BD.SociORM.SelectAllSocis();




        }
    }
}
