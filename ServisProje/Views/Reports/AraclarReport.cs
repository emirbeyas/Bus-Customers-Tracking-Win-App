using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisProje.Views.Reports
{
    public class AraclarReport
    {
        public int ID { get; set; }
        public string PLAKA { get; set; }
        public string MARKA { get; set; }
        public int KOLTUK_SAYISI { get; set; }
        public string SURUCU { get; set; }
        public int FIYAT { get; set; }
        public AraclarReport()
        {
            ID = 0;
            PLAKA = null;
            MARKA = null;
            KOLTUK_SAYISI = 0;
            SURUCU = null;
            FIYAT = 0;
        }
        public AraclarReport(DataGridViewRow r)
        {
            ID = Int32.Parse(r.Cells[0].Value.ToString());
            PLAKA = r.Cells[1].Value.ToString();
            MARKA = r.Cells[2].Value.ToString();
            KOLTUK_SAYISI = Int32.Parse(r.Cells[3].Value.ToString());
            SURUCU = r.Cells[4].Value.ToString();
            FIYAT = Int32.Parse(r.Cells[5].Value.ToString());
        }
    }
}
