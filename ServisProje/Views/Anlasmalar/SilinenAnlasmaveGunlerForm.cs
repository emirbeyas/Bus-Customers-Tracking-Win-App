using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisProje.Views.Anlasmalar
{
    public partial class SilinenAnlasmaveGunlerForm : Form
    {
        DBContext context = new DBContext();
        public SilinenAnlasmaveGunlerForm(int x)
        {
            InitializeComponent();
            if (x == 1)
            {
                lblTitle.Text = "Silinmiş Anlaşmalar";
                
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].DataPropertyName = "ANLASMA_ID";
                dataGridView1.Columns[1].HeaderText = "TANIM";
                dataGridView1.Columns[1].DataPropertyName = "ANLASMA_TANIMI";
                dataGridView1.Columns[2].HeaderText = "SER. BAŞ. SAATİ";
                dataGridView1.Columns[2].DataPropertyName = "SAAT_BAS";
                dataGridView1.Columns[3].HeaderText = "SER. BİT. SAATİ";
                dataGridView1.Columns[3].DataPropertyName = "SAAT_SON";
                dataGridView1.Columns[4].HeaderText = "ANLAŞMA BAŞ. TARİHİ";
                dataGridView1.Columns[4].DataPropertyName = "BASLANGIC_TARIH";
                dataGridView1.Columns[5].HeaderText = "ANLAŞMA BİT. TARİHİ";
                dataGridView1.Columns[5].DataPropertyName = "BITIS_TARIH";
                dataGridView1.Columns[6].HeaderText = "FİYAT";
                dataGridView1.Columns[6].DataPropertyName = "FIYAT";
                dataGridView1.Columns[7].HeaderText = "TAKSİT SAYISI";
                dataGridView1.Columns[7].DataPropertyName = "TAKSIT_SAYISI";


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = context.SP_Silinmis_anlasmalar_Listele();

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            else
            {
                lblTitle.Text = "Silinmiş Günler";

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].DataPropertyName = "ANLASMA_ID";
                dataGridView1.Columns[1].HeaderText = "PAZARTESI";
                dataGridView1.Columns[1].DataPropertyName = "PAZARTESI";
                dataGridView1.Columns[2].HeaderText = "SALI";
                dataGridView1.Columns[2].DataPropertyName = "SALI";
                dataGridView1.Columns[3].HeaderText = "CARSAMBA";
                dataGridView1.Columns[3].DataPropertyName = "CARSAMBA";
                dataGridView1.Columns[4].HeaderText = "PERSEMBE";
                dataGridView1.Columns[4].DataPropertyName = "PERSEMBE";
                dataGridView1.Columns[5].HeaderText = "CUMA";
                dataGridView1.Columns[5].DataPropertyName = "CUMA";
                dataGridView1.Columns[6].HeaderText = "CUMARTESI";
                dataGridView1.Columns[6].DataPropertyName = "CUMARTESI";
                dataGridView1.Columns[7].HeaderText = "PAZAR";
                dataGridView1.Columns[7].DataPropertyName = "PAZAR";


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = context.SP_Silinmis_gunler_Listele();

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }
    }
}
