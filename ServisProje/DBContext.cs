using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace ServisProje
{
    class DBContext
    {
        public OracleConnection con = null;
        public DBContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            con = new OracleConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed) 
                {
                    con.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw; 
            }
        }

        private void SP_Ekle(OracleCommand cmd)
        {
            try
            {
                OpenConnection();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private DataTable SP_DataTable (OracleCommand cmd)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OpenConnection();
                if(con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)cmd.Parameters["list"].Value).GetDataReader();
                    dataTable.Load(reader);
                    CloseConnection();
                }
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            return dataTable;
        }
        private int SP_Result(OracleCommand cmd)
        {
            int Result=0;
            OpenConnection();
            try
            {
                if(con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    Result = Convert.ToInt32(cmd.Parameters["p_result"].Value.ToString());
                    CloseConnection();
                }
                
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Result;
            }
            return Result;
        }

        public DataTable SP_Anlasma_listele(string p_anlasma_tanim, string p_arac_ad)
        {
            
            OracleCommand cmd = new OracleCommand("sp_anlasma_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_anlasma_tanim",p_anlasma_tanim);
            cmd.Parameters.Add("p_plaka", p_arac_ad);
            
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            return SP_DataTable(cmd);
        }
        public OracleDataReader SP_Anlasma_getByID(int ID)
        {

            OracleCommand cmd = new OracleCommand("sp_anlasma_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }
        public OracleDataReader SP_Gunler_getByID(int ID)
        {

            OracleCommand cmd = new OracleCommand("sp_gunler_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_anlasma_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Anlasma_Gun_ekle(string p_anlasma_tanim, string p_saat_bas, string p_saat_bit, string p_bas_tarih, string p_bit_tarih, int p_fiyat, 
            int p_taksit, int p_arac_id, int p_pzt, int p_sal, int p_crs, int p_prs, int p_cum, int p_cms, int p_pzr)
        {
            OracleCommand cmd = new OracleCommand("sp_anlasma_gun_ekle",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_anlasma_tanim", p_anlasma_tanim);
            cmd.Parameters.Add("p_saat_bas", p_saat_bas);
            cmd.Parameters.Add("p_saat_son", p_saat_bit);
            cmd.Parameters.Add("p_bas_tarih", p_bas_tarih);
            cmd.Parameters.Add("p_bit_tarih", p_bit_tarih);
            cmd.Parameters.Add("p_fiyat", p_fiyat);
            cmd.Parameters.Add("p_taksit", p_taksit);
            cmd.Parameters.Add("p_arac_id", p_arac_id);
            cmd.Parameters.Add("p_pzt", p_pzt);
            cmd.Parameters.Add("p_sal", p_sal);
            cmd.Parameters.Add("p_crs", p_crs);
            cmd.Parameters.Add("p_prs", p_prs);
            cmd.Parameters.Add("p_cum", p_cum);
            cmd.Parameters.Add("p_cms", p_cms);
            cmd.Parameters.Add("p_pzr", p_pzr);

            SP_Ekle(cmd);
        }

        public void SP_Anlasma_Sil(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_anlasma_sil",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            SP_Ekle(cmd);
        }

        
        public void SP_Anlasma_Guncelle(int ID ,string p_anlasma_tanim, string p_saat_bas, string p_saat_bit, string p_bas_tarih, string p_bit_tarih, int p_fiyat, 
            int p_taksit, int p_arac_id)
        {
            OracleCommand cmd = new OracleCommand("sp_anlasma_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("p_anlasma_tanim", p_anlasma_tanim);
            cmd.Parameters.Add("p_saat_bas", p_saat_bas);
            cmd.Parameters.Add("p_saat_son", p_saat_bit);
            cmd.Parameters.Add("p_bas_tarih", p_bas_tarih);
            cmd.Parameters.Add("p_bit_tarih", p_bit_tarih);
            cmd.Parameters.Add("p_fiyat", p_fiyat);
            cmd.Parameters.Add("p_taksit", p_taksit);
            cmd.Parameters.Add("p_arac_id", p_arac_id);

            SP_Ekle(cmd);
        }
        public void SP_Gun_Guncelle(int ID,int p_pzt, int p_sal, int p_crs, int p_prs, int p_cum, int p_cms, int p_pzr)
        {
            OracleCommand cmd = new OracleCommand("sp_gunler_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_anlasma_id", ID);
            cmd.Parameters.Add("p_pzt", p_pzt);
            cmd.Parameters.Add("p_sal", p_sal);
            cmd.Parameters.Add("p_crs", p_crs);
            cmd.Parameters.Add("p_prs", p_prs);
            cmd.Parameters.Add("p_cum", p_cum);
            cmd.Parameters.Add("p_cms", p_cms);
            cmd.Parameters.Add("p_pzr", p_pzr);

            SP_Ekle(cmd);
        }

        public DataTable SP_Arac_listele(string p_plaka, String p_markamodel, int p_koltuk, string p_personel_ad)
        {

            OracleCommand cmd = new OracleCommand("sp_arac_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_plaka", p_plaka);
            cmd.Parameters.Add("p_markamodel", p_markamodel);
            if (p_koltuk == 0)
            {
                cmd.Parameters.Add("p_koltuk", null);
            }
            else
            {
                cmd.Parameters.Add("p_koltuk", p_koltuk);
            }

            cmd.Parameters.Add("p_ad", p_personel_ad);

            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            return SP_DataTable(cmd);
        }

        public OracleDataReader SP_Arac_getWithID(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_arac_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Arac_ekle(string p_plaka, string p_markamodel, int p_koltuk, int p_personel_id, int p_fiyat_carpan)
        {
            OracleCommand cmd = new OracleCommand("sp_arac_ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_plaka", p_plaka);
            cmd.Parameters.Add("p_markamodel", p_markamodel);
            cmd.Parameters.Add("p_koltuk", p_koltuk);
            if (p_personel_id == 0)
            {
                cmd.Parameters.Add("p_personel_id", null);
            }
            else
            {
                cmd.Parameters.Add("p_personel_id", p_personel_id);
            }
            cmd.Parameters.Add("p_fiyat_carpani", p_fiyat_carpan);
            SP_Ekle(cmd);
        }

        public void SP_Arac_Sil(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_arac_sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            SP_Ekle(cmd);
        }

        public void SP_Arac_Guncelle(int ID, int p_koltuk, int p_personel_id, int p_fiyat_carpan)
        {
            OracleCommand cmd = new OracleCommand("sp_arac_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("p_koltuk", p_koltuk);
            
            if (p_personel_id == 0)
            {
                cmd.Parameters.Add("p_personel_id", null);
            }
            else
            {
                cmd.Parameters.Add("p_personel_id", p_personel_id);
            }
            cmd.Parameters.Add("p_fiyat_carpani", p_fiyat_carpan);
            SP_Ekle(cmd);
        }

        public DataTable SP_Personel_listele(string p_adsoyad, int p_yas, string p_gorev_ad)
        {


            OracleCommand cmd = new OracleCommand("sp_personel_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_adsoyad", p_adsoyad);
            cmd.Parameters.Add("p_telefon", null);
            cmd.Parameters.Add("p_maas", null);

            if (p_yas == 0)
            {
                cmd.Parameters.Add("p_yas", null);
            }
            else
            {
                cmd.Parameters.Add("p_yas", p_yas);
            }
            
            cmd.Parameters.Add("p_gorev_tanimi", p_gorev_ad);
            

            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            return SP_DataTable(cmd);
        }

        public OracleDataReader SP_Personel_getWithID(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_personel_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Personel_ekle(string p_adsoyad, String p_telefon, int p_yas, int p_maas, int p_gorev_id)
        {
            OracleCommand cmd = new OracleCommand("sp_personel_ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_adsoyad", p_adsoyad);
            cmd.Parameters.Add("p_yas", p_yas);
            cmd.Parameters.Add("p_telefon", p_telefon);
            cmd.Parameters.Add("p_maas", p_maas);
            cmd.Parameters.Add("p_gorev_id", p_gorev_id);
            
            SP_Ekle(cmd);
        }
        public void SP_Personel_Sil(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_personel_sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            SP_Ekle(cmd);
        }
        public void SP_Personel_Guncelle(int ID,  String p_telefon, int p_maas, int p_gorev_id)
        {
            OracleCommand cmd = new OracleCommand("sp_personel_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("p_telefon", p_telefon);
            cmd.Parameters.Add("p_maas", p_maas);
            cmd.Parameters.Add("p_gorev_id", p_gorev_id);            

            SP_Ekle(cmd);
        }

        public DataTable SP_Kullanici_listele()
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            return SP_DataTable(cmd);
        }

        public OracleDataReader SP_Kullanici_getWithID(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Kullanici_ekle(string p_username, String p_password, int p_yetki)
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_username", p_username);
            cmd.Parameters.Add("p_password", p_password);
            cmd.Parameters.Add("p_yetki", p_yetki);

            SP_Ekle(cmd);
        }

        public void SP_Kullanici_Sil(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            SP_Ekle(cmd);
        }

        public void SP_Kullanici_Guncelle(String p_username, String p_password, int p_yetki)
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_username", p_username);
            cmd.Parameters.Add("p_password", p_password);
            cmd.Parameters.Add("p_yetki", p_yetki);

            SP_Ekle(cmd);
        }

        public DataTable SP_Gorev_listele()
        {
            OracleCommand cmd = new OracleCommand("sp_gorev_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            return SP_DataTable(cmd);
        }

        public OracleDataReader SP_Gorev_getWithID(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_gorev_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Gorev_ekle(string p_tanim)
        {
            OracleCommand cmd = new OracleCommand("sp_gorev_ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_tanim", p_tanim);

            SP_Ekle(cmd);
        }

        public void SP_Gorev_Sil(string ID)
        {
            OracleCommand cmd = new OracleCommand("sp_gorev_sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_ad", ID);
            SP_Ekle(cmd);
        }
        public void SP_Gorev_Guncelle(int p_id, String p_tanim)
        {
            OracleCommand cmd = new OracleCommand("sp_gorev_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", p_id);
            cmd.Parameters.Add("p_tanim", p_tanim);

            SP_Ekle(cmd);
        }

        public DataTable SP_Yetki_listele()
        {
            OracleCommand cmd = new OracleCommand("sp_yetki_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            return SP_DataTable(cmd);
        }

        public OracleDataReader SP_Yetki_getWithID(int ID)
        {
            OracleCommand cmd = new OracleCommand("sp_yetki_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", ID);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            OracleDataReader oracleDataReader = cmd.ExecuteReader();
            return oracleDataReader;

        }

        public void SP_Yetki_ekle(int p_ekl, string p_ad, int p_sil, int p_gunc, int p_gor, int p_adm)
        {
            OracleCommand cmd = new OracleCommand("sp_yetki_ekle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_ekl", p_ekl);
            cmd.Parameters.Add("p_ad", p_ad);
            cmd.Parameters.Add("p_sil", p_sil);
            cmd.Parameters.Add("p_gunc", p_gunc);
            cmd.Parameters.Add("p_gor", p_gor);
            cmd.Parameters.Add("p_adm", p_adm);

            SP_Ekle(cmd);
        }

        public void SP_Yetki_Sil(string ID)
        {
            OracleCommand cmd = new OracleCommand("sp_yetki_sil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_ad", ID);
            SP_Ekle(cmd);
        }
        public void SP_Yetki_Guncelle(int p_id,int p_ekl, int p_sil, int p_gunc, int p_gor, int p_adm)
        {
            OracleCommand cmd = new OracleCommand("sp_yetki_guncelle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_id", p_id);
            cmd.Parameters.Add("p_ekl", p_ekl);
            cmd.Parameters.Add("p_sil", p_sil);
            cmd.Parameters.Add("p_gunc", p_gunc);
            cmd.Parameters.Add("p_gor", p_gor);
            cmd.Parameters.Add("p_adm", p_adm);

            SP_Ekle(cmd);
        }

        public bool GetLogin(string username, string password)
        {
            OracleCommand cmd = new OracleCommand("sp_kullanici_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_username", username);
            cmd.Parameters.Add("p_password", password);
            cmd.Parameters.Add("p_result", OracleDbType.Decimal,ParameterDirection.Output);

            if (SP_Result(cmd) > 0)
            {
                return true;
            }
            return false;
            
        }

        public DataTable SP_tablo_get(string p_tablo)
        {


            OracleCommand cmd = new OracleCommand("sp_tablo_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_tablo", p_tablo);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);
            return SP_DataTable(cmd);
        }

        public void SP_tablo_import(int v_id, string p_anlasma_tanim, string p_saat_bas, string p_saat_bit, string p_bas_tarih, string p_bit_tarih, int p_fiyat,
            int p_taksit, int p_arac_id, int p_pzt, int p_sal, int p_crs, int p_prs, int p_cum, int p_cms, int p_pzr)
        {
            OracleCommand cmd = new OracleCommand("sp_tablo_import", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("v_id", v_id);
            cmd.Parameters.Add("p_anlasma_tanim", p_anlasma_tanim);
            cmd.Parameters.Add("p_saat_bas", p_saat_bas);
            cmd.Parameters.Add("p_saat_son", p_saat_bit);
            cmd.Parameters.Add("p_bas_tarih", p_bas_tarih);
            cmd.Parameters.Add("p_bit_tarih", p_bit_tarih);
            cmd.Parameters.Add("p_fiyat", p_fiyat);
            cmd.Parameters.Add("p_taksit", p_taksit);
            cmd.Parameters.Add("p_arac_id", p_arac_id);
            cmd.Parameters.Add("p_pzt", p_pzt);
            cmd.Parameters.Add("p_sal", p_sal);
            cmd.Parameters.Add("p_crs", p_crs);
            cmd.Parameters.Add("p_prs", p_prs);
            cmd.Parameters.Add("p_cum", p_cum);
            cmd.Parameters.Add("p_cms", p_cms);
            cmd.Parameters.Add("p_pzr", p_pzr);

            SP_Ekle(cmd);
        }

        public void SP_diretory_create(string p_dir)
        {
            OracleCommand cmd = new OracleCommand("sp_directory_create", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_dir", p_dir);

            SP_Ekle(cmd);
        }

        public List<int> SP_anasayfa(int p_gorev_id)
        {
            List<int> values = new List<int>();
            OracleCommand cmd = new OracleCommand("sp_anasayfa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_gorev_id", p_gorev_id);
            cmd.Parameters.Add("p_surucu_sayisi", OracleDbType.Decimal, ParameterDirection.Output);
            cmd.Parameters.Add("p_personel_sayisi", OracleDbType.Decimal, ParameterDirection.Output);
            cmd.Parameters.Add("p_arac_sayisi", OracleDbType.Decimal, ParameterDirection.Output);
            cmd.Parameters.Add("p_anlasma_sayisi", OracleDbType.Decimal, ParameterDirection.Output);
            try
            {
                OpenConnection();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    int surucu = Int32.Parse(cmd.Parameters["p_surucu_sayisi"].Value.ToString());
                    int personel = Int32.Parse(cmd.Parameters["p_personel_sayisi"].Value.ToString());
                    int arac = Int32.Parse(cmd.Parameters["p_arac_sayisi"].Value.ToString());
                    int anlasma = Int32.Parse(cmd.Parameters["p_anlasma_sayisi"].Value.ToString());
                    values.Add(surucu);
                    values.Add(personel);
                    values.Add(arac);
                    values.Add(anlasma);
                    CloseConnection();
                }
            }
            catch (Exception exp)
            {
                CloseConnection();
                MessageBox.Show(exp.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return values;
        }

        public DataTable SP_GununProgrami_Listele(string p_gun)
        {

            OracleCommand cmd = new OracleCommand("sp_gununprogrami", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_gun", p_gun);
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            return SP_DataTable(cmd);
        }
        public DataTable SP_Silinmis_anlasmalar_Listele()
        {

            OracleCommand cmd = new OracleCommand("sp_silinen_anlasma_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            return SP_DataTable(cmd);
        }
        public DataTable SP_Silinmis_gunler_Listele()
        {

            OracleCommand cmd = new OracleCommand("sp_silinen_Gunler_listele", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("list", OracleDbType.RefCursor, ParameterDirection.InputOutput);

            return SP_DataTable(cmd);
        }

    }
}
