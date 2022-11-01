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
    public partial class AnlasmaDetay : Form
    {
        DBContext context = new DBContext();
        int plakaid;
        public AnlasmaDetay(int ID)
        {
            InitializeComponent();
            context.OpenConnection();
            OracleDataReader oracleDataReader = context.SP_Anlasma_getByID(ID);
            OracleDataReader oracleDataReader1 = context.SP_Gunler_getByID(ID);

            while (oracleDataReader.Read())
            {
                Tanim.Text = oracleDataReader[1].ToString();
                Tarihler.Text = oracleDataReader[4].ToString().Split(' ')[0] + " - " + oracleDataReader[5].ToString().Split(' ')[0];
                Saat.Text = oracleDataReader[2].ToString() + " - " + oracleDataReader[3].ToString();
                Fiyat.Text = oracleDataReader[6].ToString() + "₺";
                plakaid = Convert.ToInt32(oracleDataReader[8]);
            }
            OracleDataReader oracleDataReader2 = context.SP_Arac_getWithID(plakaid);
            while (oracleDataReader2.Read())
            {
                Plaka.Text = oracleDataReader2[1].ToString();
            }
            while (oracleDataReader1.Read())
            {
                if (oracleDataReader1[0].ToString() == "1")
                {
                    pzrtesiCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[1].ToString() == "1")
                {
                    saliCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[2].ToString() == "1")
                {
                    carCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[3].ToString() == "1")
                {
                    perCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[4].ToString() == "1")
                {
                    cumCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[5].ToString() == "1")
                {
                    cmrtesiCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
                if (oracleDataReader1[6].ToString() == "1")
                {
                    pzrCheck.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                }
            }

        }
    }
}
