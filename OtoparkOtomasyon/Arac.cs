using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    class Arac
    {
        public Arac()
        {
            Giris = DateTime.Now;
        }
        public string Plaka{ get; set; }
        public AracTip Tip { get; set; }
        public bool Kontak { get; set; }
        public bool Abone { get; set; }
        public DateTime Giris { get; set; }
        public DateTime Cikis { get; set; }

        public int Sure
        {
            get
            {
                TimeSpan fark = Cikis - Giris;
                if (fark - TimeSpan.FromHours((int)fark.TotalHours) > TimeSpan.Zero)
                {
                    fark = fark.Add(TimeSpan.FromHours(1));
                }
                return (int)fark.TotalHours;
            }
        }
        public decimal Ucret
        {
            get
            {
                decimal ucret = Tip.Fiyat * (Sure - 1) + Tip.Fiyat * 2;
                if (Abone)
                {
                    ucret *= 0.80m;
                }
                return ucret;
            }
        }
        public override string ToString()
        {
            string aboneSonuc = Abone ? "Abone" : "Abone Değil";
            string kontakSonuc = Kontak ? "Kontak Var" : "Kontak Yok";
            return string.Format("{0}-{1}-{2}-{3}", Plaka, Tip.Adi, aboneSonuc, kontakSonuc);
        }
    }

    class AracTip
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
