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

namespace ServisProje
{
    public partial class LoginForm : Form
    {
        DBContext context = new DBContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            label1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (context.GetLogin(textBox3.Text,textBox2.Text))
            {
                LoginUser login = new LoginUser();

                context.OpenConnection();
                OracleCommand cmd = context.con.CreateCommand();
                cmd.CommandText = "SELECT * FROM TBL_KULLANICILAR WHERE KULLANICI_ADI = '" + textBox3.Text + "' AND KULLANICI_SIFRE = '" + textBox2.Text + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader oracleDataReader = cmd.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    login.ID = Convert.ToInt32(oracleDataReader[0]);
                    login.KullaniciAdi = textBox3.Text;
                    login.Sifre = textBox2.Text;
                    login.YetkiID = Convert.ToInt32(oracleDataReader[3]);
                }

                
                OracleDataReader oracleDataReader1 = context.SP_Yetki_getWithID(login.YetkiID);
                while (oracleDataReader1.Read())
                {
                    login.YetkiSinifi = oracleDataReader1[1].ToString();
                    login.Admin = Convert.ToInt32(oracleDataReader1[6]);
                    login.Ekle = Convert.ToInt32(oracleDataReader1[2]);
                    login.Sil = Convert.ToInt32(oracleDataReader1[3]);
                    login.Guncelle = Convert.ToInt32(oracleDataReader1[4]);
                    login.Goruntule = Convert.ToInt32(oracleDataReader1[5]);
                }

                MainForm mainForm = new MainForm(login.ID, login.KullaniciAdi, login.Sifre, login.YetkiID, login.YetkiSinifi, login.Admin, login.Ekle, login.Sil, login.Guncelle, login.Goruntule);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                textBox3.Text = "";
                textBox2.Text = "";
                label1.Visible = true;
            }

            




        }
    }
}
