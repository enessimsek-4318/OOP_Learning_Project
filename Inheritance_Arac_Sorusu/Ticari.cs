using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Arac_Sorusu
{
    class Ticari : Arac
    {
        public int tasimaKapasitesi { get; set; }
        public bool ceker4 { get; set; }
        public int yolcuKapasitesi { get; set; }

        public Ticari(Marka markası, Vites vitesi, Renk rengi, double _motorHacmi, int tasimaKapasitesi, bool ceker4, int yolcuKapasitesi) : base(markası, vitesi, rengi, _motorHacmi)
        {
            this.tasimaKapasitesi = tasimaKapasitesi;
            this.ceker4 = ceker4;
            this.yolcuKapasitesi = yolcuKapasitesi;
        }
        public void ticariBilgileriYaz()
        {
            Console.WriteLine("---------------------------------------\nTİCARİ BİLGİLERİ\n---------------------------------------");
            Console.WriteLine("Marka:" + marka);
            Console.WriteLine("Vites Tipi:" + vites);
            Console.WriteLine("Aracın Rengi:" + renk);
            Console.WriteLine("Motor Hacmi:" + motorHacmi);
            Console.WriteLine("Taşıma Kapasitesi:" + tasimaKapasitesi+" Ton");
            Console.WriteLine("Arac 4x4'mü?:" + ceker4);
            Console.WriteLine("Yolcu Kapasitesi:" + yolcuKapasitesi);
        }
    }
}
