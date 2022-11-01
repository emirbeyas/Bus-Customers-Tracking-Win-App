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
using ServisProje.Views.Reports;
using Microsoft.Reporting.WinForms;

namespace ServisProje.Views.Araclar
{
    public partial class AraclarListView : UserControl
    {
        DBContext context = new DBContext();
        int Ekle, Sil, Guncelle, Goruntule, Admin;

        public AraclarListView(int YetkiID)
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

        private void ıconToolStripButton1_Click(object sender, EventArgs e)
        {
            AracEkleForm aracEkleForm = new AracEkleForm();
            aracEkleForm.ShowDialog();
            toolStripTextBox1.Text = "";        
            toolStripTextBox2.Text = "";        
            toolStripTextBox3.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Arac_listele(null,null,0,null);

        }

        private void ıconToolStripButton3_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;
            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            AracEkleForm aracEkleForm = new AracEkleForm("Araç Düzenle",ID);
            aracEkleForm.ShowDialog();
            toolStripTextBox1.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox3.Text = "";
            toolStripComboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = context.SP_Arac_listele(null, null, 0, null);
        }

        private void AraclarListView_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Add("Marka ya Göre Artan");
            toolStripComboBox1.Items.Add("Marka ya Göre Azalan");
            toolStripComboBox1.Items.Add("Koltuk Sayısı na Göre Artan");
            toolStripComboBox1.Items.Add("Koltuk Sayısı na Göre Azalan");
            toolStripComboBox1.Items.Add("Fiyat a Göre Artan");
            toolStripComboBox1.Items.Add("Fiyat a Göre Azalan");



            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ARAC_ID";
            dataGridView1.Columns[1].HeaderText = "PLAKA";
            dataGridView1.Columns[1].DataPropertyName = "PLAKA";
            dataGridView1.Columns[2].HeaderText = "MARKA";
            dataGridView1.Columns[2].DataPropertyName = "MARKA_MODEL";
            dataGridView1.Columns[3].HeaderText = "KOLTUK SAYISI";
            dataGridView1.Columns[3].DataPropertyName = "KOLTUK_SAYISI";
            dataGridView1.Columns[4].HeaderText = "SÜRÜCÜ";
            dataGridView1.Columns[4].DataPropertyName = "ADI_SOYADI";
            dataGridView1.Columns[5].HeaderText = "GÜNLÜK FIYATI";
            dataGridView1.Columns[5].DataPropertyName = "FIYAT_CARPANI";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.DataSource = context.SP_Arac_listele(null,null,0,null);

            if (Ekle != 1)
                ıconToolStripButton1.Enabled = false;
            if (Sil != 1)
                ıconToolStripButton2.Enabled = false;
            if (Guncelle != 1)
                ıconToolStripButton3.Enabled = false;
            if (Goruntule != 1)
                btnYazdır.Enabled = false;
            if (Admin == 1)
            {
                ıconToolStripButton1.Enabled = true;
                ıconToolStripButton2.Enabled = true;
                ıconToolStripButton3.Enabled = true;
                btnYazdır.Enabled = true;
            }

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.SP_Arac_listele(toolStripTextBox2.Text, toolStripTextBox3.Text, 0, toolStripTextBox1.Text);
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            List<AraclarReport> ls = new List<AraclarReport>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                AraclarReport item = new AraclarReport(dataGridView1.Rows[i]);
                ls.Add(item);
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "AraclarDataset";
            rs.Value = ls;
            ReportForm frm = new ReportForm();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "ServisProje.Views.Reports.R_Araclar.rdlc";
            frm.AnlasmalarReportBindingSource.DataSource = rs;
            frm.ShowDialog();
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.SP_Arac_listele(toolStripTextBox2.Text, toolStripTextBox3.Text, 0, toolStripTextBox1.Text);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Marka ya Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Marka ya Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Koltuk Sayısı na Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Koltuk Sayısı na Göre Azalan")
            {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            }
            else if (toolStripComboBox1.Text == "Fiyat a Göre Artan")
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            }
            else if (toolStripComboBox1.Text == "Fiyat a Göre Azalan")
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
            dataGridView1.DataSource = context.SP_Arac_listele(toolStripTextBox2.Text, toolStripTextBox3.Text, 0, toolStripTextBox1.Text);

        }

        private void ıconToolStripButton2_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            context.SP_Arac_Sil(ID);

            toolStripTextBox1.Text = "";
            toolStripTextBox2.Text = "";
            toolStripTextBox3.Text = "";
            dataGridView1.DataSource = context.SP_Arac_listele(null, null, 0, null);

        }
    }
}
