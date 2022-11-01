using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
namespace ServisProje.Views.Kullanıcılar
{
    public partial class KullaniciEkle : Form
    {
        DBContext context = new DBContext();
        private int Kullanici_ID;
        private string CmbxSlctVal;
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        public KullaniciEkle(String Title, int ID)
        {

            Kullanici_ID = ID;
            InitializeComponent();
            LblTitle.Text = Title;
            textBox1.Enabled = false;
            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Kullanici_getWithID(ID);

            while (oracleDataReader.Read())
            {
                textBox1.Text = oracleDataReader[1].ToString();
                textBox2.Text = oracleDataReader[2].ToString();
                CmbxSlctVal = oracleDataReader[3].ToString();
            }
            context.CloseConnection();

        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            context.OpenConnection();
            OracleCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TBL_YETKILER";
            cmd.CommandType = CommandType.Text;
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "YETKI_AD";
            comboBox1.ValueMember = "YETKI_ID";
            context.CloseConnection();
            if (LblTitle.Text == "Kullanıcı Düzenle")
            {
                comboBox1.SelectedValue = CmbxSlctVal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {
                string KullaniciAdi = textBox1.Text;
                string Sifre = textBox2.Text;
                int YetkiID = Convert.ToInt32(comboBox1.SelectedValue);

                if (LblTitle.Text == "Kullanıcı Düzenle")
                {
                    context.SP_Kullanici_Guncelle(KullaniciAdi,Sifre,YetkiID);
                }
                else
                {
                    context.SP_Kullanici_ekle(KullaniciAdi, Sifre, YetkiID);
                }
            }
            this.Close();
        }
    }
}
