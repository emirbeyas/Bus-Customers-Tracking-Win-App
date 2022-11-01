using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using ServisProje.Views.Reports;
using Microsoft.Reporting.WinForms;

namespace ServisProje.Views.Anlasmalar
{
    public partial class AnlasmalarListView : UserControl
    {
        DBContext context = new DBContext();
        int Ekle, Sil, Guncelle, Goruntule, Admin;
        public AnlasmalarListView(int YetkiID)
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
            AnlasmaEkleForm anlasmaEkleForm = new AnlasmaEkleForm();
            anlasmaEkleForm.ShowDialog();
            txtAd.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Anlasma_listele(null,null);

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            AnlasmaEkleForm anlasmaEkleForm = new AnlasmaEkleForm("Anlaşma Düzenle",ID);
            anlasmaEkleForm.ShowDialog();
            txtAd.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Anlasma_listele(null, null);

        }
        private void AnlasmalarListView_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Tanım a Göre Artan");
            toolStripComboBox1.Items.Add("Tanım a Göre Azalan");
            toolStripComboBox1.Items.Add("Fiyat a Göre Artan");
            toolStripComboBox1.Items.Add("Fiyat a Göre Azalan");
            toolStripComboBox1.Items.Add("Anlaşma Baş. Tar. e Göre Artan");
            toolStripComboBox1.Items.Add("Anlaşma Baş. Tar. e Göre Azalan");


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ANLASMA_ID";
            dataGridView1.Columns[1].HeaderText = "TANIM";
            dataGridView1.Columns[1].DataPropertyName = "ANLASMA_TANIMI";
            dataGridView1.Columns[2].HeaderText = "PLAKA";
            dataGridView1.Columns[2].DataPropertyName = "PLAKA";
            dataGridView1.Columns[3].HeaderText = "SER. BAŞ. SAATİ";
            dataGridView1.Columns[3].DataPropertyName = "SAAT_BAS";
            dataGridView1.Columns[4].HeaderText = "SER. BİT. SAATİ";
            dataGridView1.Columns[4].DataPropertyName = "SAAT_SON";
            dataGridView1.Columns[5].HeaderText = "ANLAŞMA BAŞ. TARİHİ";
            dataGridView1.Columns[5].DataPropertyName = "BASLANGIC_TARIH";
            dataGridView1.Columns[6].HeaderText = "ANLAŞMA BİT. TARİHİ";
            dataGridView1.Columns[6].DataPropertyName = "BITIS_TARIH";
            dataGridView1.Columns[7].HeaderText = "FİYAT";
            dataGridView1.Columns[7].DataPropertyName = "FIYAT";
            dataGridView1.Columns[8].HeaderText = "TAKSİT SAYISI";
            dataGridView1.Columns[8].DataPropertyName = "TAKSIT_SAYISI";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.SP_Anlasma_listele(null, null);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            SilinmisAnlasmalar.Enabled = false;
            SilinmisGunler.Enabled = false;

            if (Ekle != 1 )
                btnEkle.Enabled = false;
            if (Sil != 1 )
                btnSil.Enabled = false;
            if (Guncelle != 1)
                btnDuzenle.Enabled = false;
            if (Goruntule != 1)
                btnYazdır.Enabled = false;
            
            if (Admin == 1)
            {
                btnEkle.Enabled = true;
                btnSil.Enabled = true;
                btnDuzenle.Enabled = true;
                btnYazdır.Enabled = true;
                SilinmisAnlasmalar.Enabled = true;
                SilinmisGunler.Enabled = true;
            }


        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            List<AnlasmalarReport> ls = new List<AnlasmalarReport>();
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                AnlasmalarReport item = new AnlasmalarReport(dataGridView1.Rows[i]);
                ls.Add(item);
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "AnlasmalarDataset";
            rs.Value = ls;
            ReportForm frm = new ReportForm();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "ServisProje.Views.Reports.R_Anlasmalar.rdlc";
            frm.AnlasmalarReportBindingSource.DataSource = rs;
            frm.ShowDialog();
        }

        private void EskiAnlasmalar_Click(object sender, EventArgs e)
        {
            SilinenAnlasmaveGunlerForm silinenAnlasmaveGunlerForm = new SilinenAnlasmaveGunlerForm(1);
            silinenAnlasmaveGunlerForm.ShowDialog();
        }

        private void ıconToolStripButton1_Click(object sender, EventArgs e)
        {
            SilinenAnlasmaveGunlerForm silinenAnlasmaveGunlerForm = new SilinenAnlasmaveGunlerForm(2);
            silinenAnlasmaveGunlerForm.ShowDialog();
        }

        private void ıconToolStripButton1_Click_1(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            AnlasmaDetay anlasmaDetay = new AnlasmaDetay(ID);
            anlasmaDetay.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            context.SP_Anlasma_Sil(ID);

            txtAd.Text = "";
            toolStripTextBox1.Text = "";
            dataGridView1.DataSource = context.SP_Anlasma_listele(null, null);


        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.SP_Anlasma_listele(txtAd.Text, toolStripTextBox1.Text);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Tanım a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Tanım a Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Fiyat a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Fiyat a Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Anlaşma Baş. Tar. e Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Anlaşma Baş. Tar. e Göre Azalan")
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
            dataGridView1.DataSource = context.SP_Anlasma_listele(txtAd.Text, toolStripTextBox1.Text);

        }
    }
}
