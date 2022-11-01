using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisProje.Views.Reports
{
    public class AnlasmalarReport
    {
        public int ID { get; set; }
        public string TANIM { get; set; }
        public string PLAKA { get; set; }
        public string SAAT_BAS { get; set; }
        public string SAAT_SON { get; set; }
        public string BAS_TARIH { get; set; }
        public string BIT_TARIH { get; set; }
        public int FIYAT { get; set; }
        public int TAKSIT { get; set; }
        public AnlasmalarReport()
        {
            ID = 0;
            TANIM = null;
            PLAKA = null;
            SAAT_BAS = null;
            SAAT_SON = null;
            BAS_TARIH = null;
            BIT_TARIH = null;
            FIYAT = 0;
            TAKSIT = 0;
        }
        public AnlasmalarReport(int id, string tanim, string plaka, string saat_b, string saat_s, string bas_t, string bit_t, int fiyat, int taksit)
        {
            ID = id;
            TANIM = tanim;
            PLAKA = plaka;
            SAAT_BAS = saat_b;
            SAAT_SON = saat_s;
            BAS_TARIH = bas_t;
            BIT_TARIH = bit_t;
            FIYAT = fiyat;
            TAKSIT = taksit;
        }
        public AnlasmalarReport(DataGridViewRow r)
        {
            ID = Int32.Parse(r.Cells[0].Value.ToString());
            TANIM = r.Cells[1].Value.ToString();
            PLAKA = r.Cells[2].Value.ToString();
            SAAT_BAS = r.Cells[3].Value.ToString();
            SAAT_SON = r.Cells[4].Value.ToString();
            BAS_TARIH = r.Cells[5].Value.ToString();
            BIT_TARIH = r.Cells[6].Value.ToString();
            FIYAT = Int32.Parse(r.Cells[7].Value.ToString());
            TAKSIT = Int32.Parse(r.Cells[8].Value.ToString());
        }
    }
}
