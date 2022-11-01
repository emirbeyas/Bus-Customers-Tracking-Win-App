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
namespace ServisProje.Views.Araclar
{
    public partial class AracEkleForm : Form
    {
        private int Arac_ID;
        DBContext context = new DBContext();
        private string CmbxSlctVal;
        public AracEkleForm()
        {
            InitializeComponent();
        }
        public AracEkleForm(String Title,int ID)
        {
            Arac_ID = ID;
            InitializeComponent();
            LblTitle.Text = Title;
            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Arac_getWithID(ID);

            while (oracleDataReader.Read())
            {
                textBox3.Text = oracleDataReader[1].ToString();
                textBox2.Text = oracleDataReader[2].ToString();
                textBox1.Text = oracleDataReader[3].ToString();
                textBox4.Text = oracleDataReader[5].ToString();
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                if (oracleDataReader[4].ToString() != "")
                {
                    checkBox1.Checked = true;
                    comboBox1.Visible = true;
                    CmbxSlctVal = oracleDataReader[4].ToString();
                }

            }
            context.CloseConnection();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AracEkleForm_Load(object sender, EventArgs e)
        {
            
            comboBox1.Visible = false;
            if (checkBox1.Checked)
            {

                comboBox1.Visible = true;
            }

            context.OpenConnection();
            OracleCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM VIEW_PERSONEL WHERE GOREV_TANIMI = 'Sürücü'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "ADI_SOYADI";
            comboBox1.ValueMember = "PERSONEL_ID";
            context.CloseConnection();
            if (LblTitle.Text == "Araç Düzenle")
            {
                if (CmbxSlctVal != null)
                {
                    comboBox1.SelectedValue = CmbxSlctVal;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {
                string p_plaka = textBox3.Text;
                string p_markamodel = textBox2.Text;
                int p_koltuk = Convert.ToInt32(textBox1.Text);
                int p_personel_id = Convert.ToInt32(comboBox1.SelectedValue);
                int p_fiyat_carpan = Convert.ToInt32(textBox4.Text);
                if (LblTitle.Text == "Araç Düzenle")
                {
                    if (comboBox1.Visible)
                    {
                        context.SP_Arac_Guncelle(Arac_ID, p_koltuk, p_personel_id, p_fiyat_carpan);
                    }
                    else
                    {
                        context.SP_Arac_Guncelle(Arac_ID, p_koltuk, 0, p_fiyat_carpan);
                    }
                }
                else
                {
                    if (comboBox1.Visible)
                    {
                        context.SP_Arac_ekle(p_plaka, p_markamodel, p_koltuk, p_personel_id, p_fiyat_carpan);
                    }
                    else
                    {
                        context.SP_Arac_ekle(p_plaka, p_markamodel, p_koltuk, 0, p_fiyat_carpan);
                    }
                }
                this.Close();

            }
        }
    }
}
