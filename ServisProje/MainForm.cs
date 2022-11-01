using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ServisProje.Views.Anasayfa;
using ServisProje.Views.Kullanıcılar;
using ServisProje.Views.Araclar;
using ServisProje.Views.Personeller;
using ServisProje.Views.Anlasmalar;
using ServisProje.Views.Yedekleme;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace ServisProje
{
    public partial class MainForm : Form
    {
        LoginUser user = new LoginUser();
        public MainForm(int ID, string KullaniciAdi, String Sifre, int YetkiID, string YetkiSinif, int Admin, int Ekle, int Sil, int Guncelle, int Goruntule)
        {
            InitializeComponent();
            user.ID = ID;
            user.KullaniciAdi = KullaniciAdi;
            user.Sifre = Sifre;
            user.YetkiID = YetkiID;
            user.YetkiSinifi = YetkiSinif;
            user.Admin = Admin;
            user.Ekle = Ekle;
            user.Sil = Sil;
            user.Guncelle = Guncelle;
            user.Goruntule = Goruntule;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(new AnasayfaView());
            AnasayfaButton.BackColor = Color.FromArgb(0, 192, 239);
            label2.Text = user.KullaniciAdi;

            if (user.Admin != 1)
            {
                YedeklemeButton.Visible = false;
                KullanicilarButton.Visible = false;
            }



        }
        private void ButtonDisable()
        {
            AnasayfaButton.BackColor = Color.FromArgb(34,45,50);
            AnlasmalarButton.BackColor = Color.FromArgb(34, 45, 50);
            AraclarButton.BackColor = Color.FromArgb(34, 45, 50);
            PersonellerButton.BackColor = Color.FromArgb(34, 45, 50);
            KullanicilarButton.BackColor = Color.FromArgb(34, 45, 50);
            YedeklemeButton.BackColor = Color.FromArgb(34,45,50);
            
        }
        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            AnasayfaButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new AnasayfaView()) ;
        }

        private void AnlasmalarButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            AnlasmalarButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new AnlasmalarListView(user.YetkiID));
        }

        private void AraclarButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            AraclarButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new AraclarListView(user.YetkiID));
        }

        private void PersonellerButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            PersonellerButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new PersonellerListView(user.YetkiID));
        }

        private void KullanicilarButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            KullanicilarButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new KullanicilarListView());
            
        }

        private void YedeklemeButton_Click(object sender, EventArgs e)
        {
            ButtonDisable();
            YedeklemeButton.BackColor = Color.FromArgb(0, 192, 239);
            panel2.Controls.Clear();
            panel2.Controls.Add(new YedeklemeView());

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user.ID,user.YetkiSinifi);
            profile.ShowDialog();
        }
    }
}
