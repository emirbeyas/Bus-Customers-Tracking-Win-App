using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisProje.Views.Anasayfa
{
    public partial class AnasayfaView : UserControl
    {
        DBContext context = new DBContext();
        public AnasayfaView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            List<int> values = context.SP_anasayfa(1);
            SurucuSayisi.Text = values[0].ToString();
            PersonelSayisi.Text = values[1].ToString();
            AracSayisi.Text = values[2].ToString();
            AnlasmalarSayisi.Text = values[3].ToString();
            string a = DateTime.Now.DayOfWeek.ToString();
        }

        private void AnasayfaView_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ANLASMA_ID";
            dataGridView1.Columns[1].HeaderText = "TANIM";
            dataGridView1.Columns[1].DataPropertyName = "ANLASMA_TANIMI";
            dataGridView1.Columns[2].HeaderText = "SER. BAŞ. SAATİ";
            dataGridView1.Columns[2].DataPropertyName = "SAAT_BAS";
            dataGridView1.Columns[3].HeaderText = "SER. BİT. SAATİ";
            dataGridView1.Columns[3].DataPropertyName = "SAAT_SON";
            dataGridView1.Columns[4].HeaderText = "PLAKA";
            dataGridView1.Columns[4].DataPropertyName = "PLAKA";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.SP_GununProgrami_Listele(DateTime.Now.DayOfWeek.ToString());

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
