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

namespace ServisProje.Views.Personeller
{
    public partial class PersonelEkleForm : Form
    {
        DBContext context = new DBContext();
        private int Personel_ID;
        private string cmbxsltval;
        public PersonelEkleForm()
        {
            InitializeComponent();
        }        
        public PersonelEkleForm(String Title,int ID)
        {
            Personel_ID = ID;
            InitializeComponent();
            LblTitle.Text = Title;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Personel_getWithID(ID);

            while (oracleDataReader.Read())
            {
                textBox1.Text = oracleDataReader[1].ToString();
                maskedTextBox1.Text = oracleDataReader[3].ToString();
                textBox3.Text = oracleDataReader[2].ToString();
                textBox4.Text = oracleDataReader[4].ToString();
                cmbxsltval = oracleDataReader[5].ToString();
            }
            context.CloseConnection();


        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            context.OpenConnection();
            OracleCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TBL_GOREVLER";
            cmd.CommandType = CommandType.Text;
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "GOREV_TANIMI";
            comboBox1.ValueMember = "GOREV_ID";
            context.CloseConnection();
            
            if (LblTitle.Text == "Personel Düzenle")
            {
                if (cmbxsltval != "")
                {
                    comboBox1.SelectedValue = cmbxsltval;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || maskedTextBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {
                string p_adsoyad = textBox1.Text;
                string p_telefon = maskedTextBox1.Text;
                int p_yas = Convert.ToInt32(textBox3.Text);
                int p_maas = Convert.ToInt32(textBox4.Text);
                int p_gorev_id = Convert.ToInt32(comboBox1.SelectedValue);

                if (LblTitle.Text == "Personel Düzenle")
                {
                    context.SP_Personel_Guncelle(Personel_ID, p_telefon, p_maas, p_gorev_id);
                }
                else
                {
                    context.SP_Personel_ekle(p_adsoyad, p_telefon, p_yas, p_maas, p_gorev_id);
                }
            }
            this.Close();
        }
    }
}
