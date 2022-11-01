using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace ServisProje.Views.Personeller
{
    public partial class PersonellerListView : UserControl
    {
        DBContext context = new DBContext();
        int Ekle, Sil, Guncelle, Goruntule, Admin;

        public PersonellerListView(int YetkiID)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Yetki_getWithID(YetkiID);
            while (oracleDataReader.Read())
            {
                Ekle = Convert.ToInt32(oracleDataReader[2]);
                Sil = Convert.ToInt32(oracleDataReader[3]);
                Guncelle = Convert.ToInt32(oracleDataReader[4]);
                Goruntule = Convert.ToInt32(oracleDataReader[5]);
                Admin = Convert.ToInt32(oracleDataReader[6]);
            }
            context.CloseConnection();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkleForm personelEkleForm = new PersonelEkleForm();
            personelEkleForm.ShowDialog();
            txtAd.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Personel_listele(null,0,null);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;
            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            PersonelEkleForm personelEkleForm = new PersonelEkleForm("Personel Düzenle",ID);
            personelEkleForm.ShowDialog();
            txtAd.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Personel_listele(null, 0, null);
        }

        private void PersonellerListView_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Ad Soyad a Göre Artan");
            toolStripComboBox1.Items.Add("Ad Soyad a Göre Azalan");
            toolStripComboBox1.Items.Add("Yaş a Göre Artan");
            toolStripComboBox1.Items.Add("Yaş a Göre Azalan");
            toolStripComboBox1.Items.Add("Maaş a Göre Artan");
            toolStripComboBox1.Items.Add("Maaş a Göre Azalan");


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "PERSONEL_ID";
            dataGridView1.Columns[1].HeaderText = "ADI SOYADI";
            dataGridView1.Columns[1].DataPropertyName = "ADI_SOYADI";
            dataGridView1.Columns[2].HeaderText = "TELEFON NUMARASI";
            dataGridView1.Columns[2].DataPropertyName = "TELEFON_NO";
            dataGridView1.Columns[3].HeaderText = "YAŞI";
            dataGridView1.Columns[3].DataPropertyName = "YAS";
            dataGridView1.Columns[4].HeaderText = "GÖREVİ";
            dataGridView1.Columns[4].DataPropertyName = "GOREV_TANIMI";
            dataGridView1.Columns[5].HeaderText = "MAAŞI";
            dataGridView1.Columns[5].DataPropertyName = "MAAS";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.DataSource = context.SP_Personel_listele(null,0,null);

            if (Ekle != 1)
                btnEkle.Enabled = false;
            if (Sil != 1)
                btnSil.Enabled = false;
            if (Guncelle != 1)
                btnDuzenle.Enabled = false;

            if (Admin == 1)
            {
                btnEkle.Enabled = true;
                btnSil.Enabled = true;
                btnDuzenle.Enabled = true;

            }

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.SP_Personel_listele(txtAd.Text,0,toolStripTextBox1.Text);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Ad Soyad a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Ad Soyad a Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Yaş a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Yaş a Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Maaş a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Maaş a Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.SP_Personel_listele(txtAd.Text, 0, toolStripTextBox1.Text);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            context.SP_Personel_Sil(ID);

            toolStripTextBox1.Text = "";
            txtAd.Text = "";
            dataGridView1.DataSource = context.SP_Personel_listele(null, 0, null);


        }
    }
}
