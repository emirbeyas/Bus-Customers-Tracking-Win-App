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
namespace ServisProje.Views.Anlasmalar
{
    public partial class AnlasmaEkleForm : Form
    {
        DBContext context = new DBContext();
        private int Anlasma_ID;
        private string CmbxSlctVal;

        public AnlasmaEkleForm()
        {
            InitializeComponent();
            
        }
        
        public AnlasmaEkleForm(String Title,int ID)
        {
            Anlasma_ID = ID;
            InitializeComponent();
            LblTitle.Text = Title;
            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Anlasma_getByID(ID);
            OracleDataReader oracleDataReader1 = context.SP_Gunler_getByID(ID);

            while (oracleDataReader.Read())
            {
                textBox1.Text = oracleDataReader[1].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(oracleDataReader[4].ToString());
                dateTimePicker2.Value = Convert.ToDateTime(oracleDataReader[5].ToString());
                dateTimePicker3.Value = Convert.ToDateTime(oracleDataReader[2].ToString());
                dateTimePicker4.Value = Convert.ToDateTime(oracleDataReader[3].ToString());
                CmbxSlctVal = oracleDataReader[8].ToString();
                textBox6.Text = oracleDataReader[6].ToString();
                textBox7.Text = oracleDataReader[7].ToString();

            }
            while (oracleDataReader1.Read())
            {
                if (oracleDataReader1[0].ToString() == "1")
                {
                    checkBox1.Checked = true;
                }
                if (oracleDataReader1[1].ToString() == "1")
                {
                    checkBox2.Checked = true;
                }
                if (oracleDataReader1[2].ToString() == "1")
                {
                    checkBox3.Checked = true;
                }
                if (oracleDataReader1[3].ToString() == "1")
                {
                    checkBox4.Checked = true;
                }
                if (oracleDataReader1[4].ToString() == "1")
                {
                    checkBox5.Checked = true;
                }
                if (oracleDataReader1[5].ToString() == "1")
                {
                    checkBox6.Checked = true;
                }
                if (oracleDataReader1[6].ToString() == "1")
                {
                    checkBox8.Checked = true;
                }

            }

            context.CloseConnection();
        }

        private void AnlasmaEkleForm_Load(object sender, EventArgs e)
        {
            
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker3.ShowUpDown = true;
            

            comboBox1.Items.Clear();

            context.OpenConnection();
            OracleCommand cmd = context.con.CreateCommand();
            cmd.CommandText = "SELECT * FROM TBL_ARACLAR";
            cmd.CommandType = CommandType.Text;
            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(oracleDataReader);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "PLAKA";
            comboBox1.ValueMember = "ARAC_ID";
            context.CloseConnection();
            if (LblTitle.Text == "Anlaşma Düzenle")
            {
                comboBox1.SelectedValue = CmbxSlctVal;
                checkBox7.Visible = false;
                textBox6.Enabled = true;
            }
            checkBox7.Checked = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] gunler = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            string Tanim, Anlasma_bas_tar, Anlasma_bit_tar, Servis_bas_saati, servis_bit_saati;
            int Arac_id, Taksit_sayisi , Fiyat;

            if (checkBox1.Checked) { gunler[0] = 1; }
            else { gunler[0] = 0; }

            if (checkBox2.Checked) { gunler[1] = 1; }
            else { gunler[1] = 0; }

            if (checkBox3.Checked) { gunler[2] = 1; }
            else { gunler[2] = 0; }

            if (checkBox4.Checked) { gunler[3] = 1; }
            else { gunler[3] = 0; }

            if (checkBox5.Checked) { gunler[4] = 1; }
            else { gunler[4] = 0; }

            if (checkBox6.Checked) { gunler[5] = 1; }
            else { gunler[5] = 0; }

            if (checkBox8.Checked) { gunler[6] = 1; }
            else { gunler[6] = 0; }
            
            if (textBox1.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else {

                Tanim = textBox1.Text;
                Anlasma_bas_tar = dateTimePicker1.Text;
                Anlasma_bit_tar = dateTimePicker2.Text;
                Servis_bas_saati = dateTimePicker3.Text;
                servis_bit_saati = dateTimePicker4.Text;
                Arac_id = Convert.ToInt32(comboBox1.SelectedValue);
                Taksit_sayisi = Convert.ToInt32(textBox7.Text);
                if ( checkBox7.Checked == false || textBox6.Text == "")
                {
                    Fiyat = 0;
                }
                else { Fiyat = Convert.ToInt32(textBox6.Text); }

                if (LblTitle.Text == "Anlaşma Düzenle")
                {
                    context.SP_Anlasma_Guncelle(Anlasma_ID, Tanim, Servis_bas_saati, servis_bit_saati, Anlasma_bas_tar, Anlasma_bit_tar, Fiyat,
                    Taksit_sayisi, Arac_id);

                    context.SP_Gun_Guncelle(Anlasma_ID, gunler[0], gunler[1], gunler[2], gunler[3], gunler[4], gunler[5], gunler[6]);
                }
                else {
                context.SP_Anlasma_Gun_ekle(Tanim, Servis_bas_saati, servis_bit_saati, Anlasma_bas_tar, Anlasma_bit_tar, Fiyat,
                    Taksit_sayisi, Arac_id, gunler[0], gunler[1], gunler[2], gunler[3], gunler[4], gunler[5], gunler[6]);
                }
                
                this.Close();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
            }
        }
    }
}
