using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisProje.Views.Yedekleme
{
    public partial class YetkiEkleForm : Form
    {
        DBContext context = new DBContext();
        int Yetki_ID;
        public YetkiEkleForm()
        {
            InitializeComponent();
        }
        
        public YetkiEkleForm(String Title, int ID)
        {
            InitializeComponent();
            Yetki_ID = ID;
            LblTitle.Text = Title;
            textBox1.Enabled = false;

            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Yetki_getWithID(ID);

            while (oracleDataReader.Read())
            {
                textBox1.Text = oracleDataReader[1].ToString();

                if(Convert.ToInt32(oracleDataReader[6]) == 1)
                {
                    checkBox5.Checked = true;

                }
                else
                {
                    if(Convert.ToInt32(oracleDataReader[2]) == 1)
                    {
                        checkBox1.Checked = true;
                    }
                    if(Convert.ToInt32(oracleDataReader[3]) == 1)
                    {
                        checkBox2.Checked = true;
                    }
                    if(Convert.ToInt32(oracleDataReader[5]) == 1)
                    {
                        checkBox4.Checked = true;
                    }
                    if(Convert.ToInt32(oracleDataReader[4]) == 1)
                    {
                        checkBox3.Checked = true;
                    }
                }
                
                
            }
            context.CloseConnection();


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
            }
            else
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {
                String Ad = textBox1.Text;
                int ekl=0, sil=0, gunc=0, gor=0, adm=0;
                if (checkBox5.Checked)
                {
                    adm = 1;
                }
                else
                {
                    if (checkBox1.Checked)
                        ekl = 1;
                    if (checkBox2.Checked)
                        sil = 1;
                    if (checkBox3.Checked)
                        gunc = 1;
                    if (checkBox4.Checked)
                        gor = 1;
                }
                

                if (LblTitle.Text == "Yetki Sınıfı Düzenle")
                {
                    context.SP_Yetki_Guncelle(Yetki_ID, ekl, sil, gunc, gor, adm);
                }
                else
                {
                    context.SP_Yetki_ekle(ekl, Ad, sil, gunc, gor, adm);
                }
            }
            this.Close();
        }
    }
}
