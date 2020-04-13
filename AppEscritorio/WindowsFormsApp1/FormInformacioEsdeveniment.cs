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
    public partial class FormInformacioEsdeveniment : Form
    {
        public FormInformacioEsdeveniment(Esdeveniment esdeveniment)
        {
            InitializeComponent();
            List<Assistir> assistir = BD.AssistirORM.SelectAllAssitir(esdeveniment.id);

            
            
            labelNomEsdeveniment.Text = esdeveniment.NombreEvento;

           bindingSourceAssistir.DataSource = BD.AssistirORM.SelectAllAssitir(esdeveniment.id);


          


        }

        private void FormInformacioEsdeveniment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Assistir asi = (Assistir)dataGridViewValoracions.SelectedRows[0].DataBoundItem;
            List<Socis> soci = BD.SociORM.SelectunSoci(asi.id_Soci);

            MessageBox.Show("\n DNI: " + soci[0].DNI + "\n Nom: " + soci[0].nom + "\n Cognom: " + soci[0].cognoms + "\n Telefono: " + soci[0].telefon +  "\n Mail: " + soci[0].mail, "Información socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
