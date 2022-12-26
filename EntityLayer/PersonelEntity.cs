using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class PersonelEntity
    {
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelSehir { get; set; }
        public short PersonelMaas { get; set; }
        public bool PersonelDurum { get; set; }
        public string PersonelMeslek { get; set; }

    }
}
