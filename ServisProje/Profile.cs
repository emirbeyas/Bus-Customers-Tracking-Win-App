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

namespace ServisProje
{
    public partial class Profile : Form
    {
        DBContext context = new DBContext();
        string kullaniciAdi, yetkiSinifi, Sifre;
        int ID,yetkiID;
        public Profile(int ID,string yetkiSinifi)
        {
            InitializeComponent();
            this.ID = ID;
            this.yetkiSinifi = yetkiSinifi;

            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Kullanici_getWithID(ID);
            while(oracleDataReader.Read()){
                kullaniciAdi = oracleDataReader[1].ToString();
                Sifre = oracleDataReader[2].ToString();
                yetkiID = Convert.ToInt32(oracleDataReader[3]);
            }

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Şifre";
            textBox1.Text = "Yeni Şifre";
            label2.Text = kullaniciAdi;
            label3.Text = yetkiSinifi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {


                if (textBox3.Text == Sifre)
                {
                    context.SP_Kullanici_Guncelle(kullaniciAdi, textBox1.Text, yetkiID);
                    MessageBox.Show("Şifreniz Değiştirildi.", "Başarılı", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış.", "HATA", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Şifre")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Şifre";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yeni Şifre")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Yeni Şifre";
            }
        }
    }
}
