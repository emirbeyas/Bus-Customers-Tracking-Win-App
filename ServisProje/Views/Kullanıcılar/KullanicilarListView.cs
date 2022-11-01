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
namespace ServisProje.Views.Kullanıcılar
{
    public partial class KullanicilarListView : UserControl
    {
        DBContext context = new DBContext();


        public KullanicilarListView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.ShowDialog();
            dataGridView1.DataSource = context.SP_Kullanici_listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;
            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            KullaniciEkle kullaniciEkle = new KullaniciEkle("Kullanıcı Düzenle",ID);
            kullaniciEkle.ShowDialog();

            dataGridView1.DataSource = context.SP_Kullanici_listele();

        }

        private void KullanicilarListView_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "KULLANICI_ID";
            dataGridView1.Columns[1].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[1].DataPropertyName = "KULLANICI_ADI";
            dataGridView1.Columns[2].HeaderText = "ŞİFRE";
            dataGridView1.Columns[2].DataPropertyName = "KULLANICI_SIFRE";
            dataGridView1.Columns[3].HeaderText = "YETKİ SINIF";
            dataGridView1.Columns[3].DataPropertyName = "YETKI_AD";

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dataGridView1.DataSource = context.SP_Kullanici_listele();
            
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;

            int ID = Convert.ToInt32(dataGridView1.Rows[secsatir].Cells[0].Value);

            context.SP_Kullanici_Sil(ID);

            dataGridView1.DataSource = context.SP_Kullanici_listele();
        }
    }
}
