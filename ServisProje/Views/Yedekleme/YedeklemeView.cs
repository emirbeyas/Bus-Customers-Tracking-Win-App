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
using System.Diagnostics;
using System.IO;
using CsvHelper;

namespace ServisProje.Views.Yedekleme
{
    public partial class YedeklemeView : UserControl
    {

        DBContext context = new DBContext();
        List<AnlasmaGun> anlasmaGun = new List<AnlasmaGun>();
        public YedeklemeView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void YedeklemeView_Load(object sender, EventArgs e)
        {
            btnDuzenle.Visible = false;
            btnEkle.Visible = false;
            btnSil.Visible = false;
            label1.Text = "";
        }

        private void gOREVLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "GOREV TANIMI";
            dataGridView1.Columns[0].DataPropertyName = "GOREV_TANIMI";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.SP_Gorev_listele();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            label1.Text = "GÖREVLER";
            btnDuzenle.Visible = false;
            btnEkle.Visible = true;
            btnSil.Visible = true;
        }

        private void yETKİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "YETKİ SINIFI";
            dataGridView1.Columns[0].DataPropertyName = "YETKI_AD";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = context.SP_Yetki_listele();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            label1.Text = "YETKİLER";
            btnDuzenle.Visible = true;
            btnEkle.Visible = true;
            btnSil.Visible = true;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int ID = 0;
            int secsatir = dataGridView1.SelectedCells[0].RowIndex;
            string YetkiAd = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

            context.OpenConnection();
            OracleCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TBL_YETKILER WHERE YETKI_AD = '" + YetkiAd + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            while (oracleDataReader.Read())
            {
                ID = Convert.ToInt32(oracleDataReader[0]);
            }
            context.CloseConnection();

            

            YetkiEkleForm yetkiEkleForm = new YetkiEkleForm("Yetki Sınıfı Düzenle", ID);
            yetkiEkleForm.ShowDialog();

            dataGridView1.DataSource = context.SP_Yetki_listele();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (label1.Text == "GÖREVLER")
            {
                GorevEkleForm gorevEkleForm = new GorevEkleForm();
                gorevEkleForm.ShowDialog();

                dataGridView1.DataSource = context.SP_Gorev_listele();
            }
            else
            {
                YetkiEkleForm yetkiEkleForm = new YetkiEkleForm();
                yetkiEkleForm.ShowDialog();

                dataGridView1.DataSource = context.SP_Yetki_listele();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            

            if (label1.Text == "GÖREVLER")
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;

                string ID = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

                context.SP_Gorev_Sil(ID);

                dataGridView1.DataSource = context.SP_Gorev_listele();
            }
            else
            {
                int secsatir = dataGridView1.SelectedCells[0].RowIndex;

                string ID = dataGridView1.Rows[secsatir].Cells[0].Value.ToString();

                context.SP_Yetki_Sil(ID);

                dataGridView1.DataSource = context.SP_Yetki_listele();
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;

            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView3.DataSource = context.SP_tablo_get(cbxTablo.SelectedItem.ToString());

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            btnDısaAktar.Visible = true;
            btnDısaAktar.Enabled = true;
        }

        private void btnDısaAktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog() { Filter = "CSV dosyaları|*.csv" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var textWriter = File.CreateText(fileDialog.FileName);
                    CsvWriter csv = new CsvWriter(textWriter, System.Globalization.CultureInfo.CurrentCulture);
                    DataTable dt = context.SP_tablo_get(cbxTablo.SelectedItem.ToString());
                    foreach (DataColumn column in dt.Columns)
                        csv.WriteField(column.ColumnName);
                    csv.NextRecord();
                    foreach(DataRow row in dt.Rows)
                    {
                        for(var i = 0; i < dt.Columns.Count; i++)
                        {
                            csv.WriteField(row[i]);
                        }
                        csv.NextRecord();
                    }
                    textWriter.Close();
                    MessageBox.Show("Başarıyla dışa aktarıldı.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "CSV dosyaları|*.csv" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtDosyaYol.Text = fileDialog.FileName;
                    DataTable dt = new DataTable();
                    string[] allLines = File.ReadAllLines(fileDialog.FileName);
                    string[] columns = allLines[0].Split(new char[] { ';' });
                    foreach(string column in columns)
                    {
                        dt.Columns.Add(column);
                    }
                    for(int i = 1; i < allLines.Length; i++)
                    {
                        string[] row = allLines[i].Split(new char[] { ';' });
                        dt.Rows.Add(row);
                        AnlasmaGun newAG = new AnlasmaGun();
                        newAG.ANLASMA_ID = Int32.Parse(row[0]);
                        newAG.ANLASMA_TANIMI = row[1];
                        newAG.SAAT_BAS = row[2];
                        newAG.SAAT_SON = row[3];
                        newAG.BASLANGIC_TARIH = row[4].Split(' ')[0];
                        newAG.BITIS_TARIH = row[5].Split(' ')[0];
                        newAG.FIYAT = Int32.Parse(row[6]);
                        newAG.TAKSIT_SAYISI = Int32.Parse(row[7]);
                        newAG.ARAC_ID = Int32.Parse(row[8]);
                        newAG.PAZARTESI = Int32.Parse(row[9]);
                        newAG.SALI = Int32.Parse(row[10]);
                        newAG.CARSAMBA = Int32.Parse(row[11]);
                        newAG.PERSEMBE = Int32.Parse(row[12]);
                        newAG.CUMA = Int32.Parse(row[13]);
                        newAG.CUMARTESI = Int32.Parse(row[14]);
                        newAG.PAZAR = Int32.Parse(row[15]);
                        anlasmaGun.Add(newAG);
                    }
                    dataGridView2.DataSource = null;
                    dataGridView2.AutoGenerateColumns = true;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.DataSource = dt;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    MessageBox.Show("Başarıyla açıldı", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnIceAktar.Enabled = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public class AnlasmaGun
        {
            public int ANLASMA_ID { get; set; }
            public string ANLASMA_TANIMI { get; set; }
            public string SAAT_BAS { get; set; }
            public string SAAT_SON { get; set; }
            public string BASLANGIC_TARIH { get; set; }
            public string BITIS_TARIH { get; set; }
            public int FIYAT { get; set; }
            public int TAKSIT_SAYISI { get; set; }
            public int ARAC_ID { get; set; }
            public int PAZARTESI { get; set; }
            public int SALI { get; set; }
            public int CARSAMBA { get; set; }
            public int PERSEMBE { get; set; }
            public int CUMA { get; set; }
            public int CUMARTESI { get; set; }
            public int PAZAR { get; set; }
            public AnlasmaGun()
            {
                ANLASMA_ID = 0;
                ANLASMA_TANIMI = null;
                SAAT_BAS = null;
                SAAT_SON = null;
                BASLANGIC_TARIH = null;
                BITIS_TARIH = null;
                FIYAT = 0;
                TAKSIT_SAYISI = 0;
                ARAC_ID = 0;
                PAZARTESI = 0;
                SALI = 0;
                CARSAMBA = 0;
                PERSEMBE = 0;
                CUMA = 0;
                CUMARTESI = 0;
                PAZAR = 0;
            }
        }

        private void btnIceAktar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Verileri içe aktarmak istiyor musunuz?","Tablo İçe Aktar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    foreach (AnlasmaGun ang in anlasmaGun)
                    {
                        context.SP_tablo_import(ang.ANLASMA_ID, ang.ANLASMA_TANIMI, ang.SAAT_BAS, ang.SAAT_SON, ang.BASLANGIC_TARIH, ang.BITIS_TARIH, ang.FIYAT, ang.TAKSIT_SAYISI, ang.ARAC_ID, ang.PAZARTESI, ang.SALI, ang.CARSAMBA, ang.PERSEMBE, ang.CUMA, ang.CUMARTESI, ang.PAZAR);
                    }
                    MessageBox.Show("İçe Aktarma Tamanlandı", "Tablo İçe Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog() { Filter = "DMP dosyaları|*.dmp" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (System.IO.File.Exists(fileDialog.FileName))
                    {
                        MessageBox.Show("Dosya zaten mevcut. Lütfen başka bir isim ile kaydedin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string dir = Path.GetDirectoryName(fileDialog.FileName);
                        string file = Path.GetFileName(fileDialog.FileName);
                        string fName = Path.GetFileNameWithoutExtension(fileDialog.FileName);
                        context.SP_diretory_create(dir);
                        string cmd = "expdp servis_db/1234 schemas=SERVIS_DB directory=servis_db_pump dumpfile=" + file + " logfile=" + fName + ".log";
                        //string cmd = "expdp servis_db/1234 schemas=SERVIS_DB directory=servis_db_pump dumpfile=servis.dmp logfile=expdpServis.log";
                        Process p = new Process();
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.Arguments = "/c " + cmd;
                        p.Start();
                        p.WaitForExit();
                        p.Dispose();
                        MessageBox.Show("Yedekleme Tamamlandı", "Yedekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnYedektenDon_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "DMP dosyaları|*.dmp" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string dir = Path.GetDirectoryName(fileDialog.FileName);
                    string file = Path.GetFileName(fileDialog.FileName);
                    string fName = Path.GetFileNameWithoutExtension(fileDialog.FileName);
                    context.SP_diretory_create(dir);
                    string cmd = "impdp servis_db/1234 schemas=SERVIS_DB directory=servis_db_pump dumpfile=" + file + " logfile=" + fName + ".log table_exists_action=replace";
                    //string cmd = "expdp servis_db/1234 schemas=SERVIS_DB directory=servis_db_pump dumpfile=servis.dmp logfile=expdpServis.log";
                    Process p = new Process();
                    p.StartInfo.FileName = "cmd.exe";
                    p.StartInfo.Arguments = "/c " + cmd;
                    p.Start();
                    p.WaitForExit();
                    p.Dispose();
                    MessageBox.Show("Yedekten Geri Yükleme Tamamlandı", "Yedek Geri Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
