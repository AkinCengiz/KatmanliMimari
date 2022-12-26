using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class YoneticiEntity
    {
        private string _kullaniciAd;
        private string _sifre;

        public string KullaniciAd { get => _kullaniciAd; set => _kullaniciAd = value; }
        public string Sifre { get => _sifre; set => _sifre = value; }
    }
}
