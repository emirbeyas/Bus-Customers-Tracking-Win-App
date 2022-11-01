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
    public partial class GorevEkleForm : Form
    {
        DBContext context = new DBContext();
        public GorevEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz.", "HATA", MessageBoxButtons.OK);
            }
            else
            {
                context.SP_Gorev_ekle(textBox1.Text);
            }
            this.Close();
        }
    }
}
