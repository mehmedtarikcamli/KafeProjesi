using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Data
{
    public class Siparis
    {
        private SiparisDurum durum;

        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; } = SiparisDurum.Aktif;
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; }
        public DateTime? KapanisZamani { get; set; } = DateTime.Now;

        public List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();

        public string ToplamTutarTL => ToplamTutar().ToString("c2");

        private decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(sd => sd.Tutar());
        }
    }
}
