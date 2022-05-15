using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Arac_Sorusu
{
    class Otomobil : Arac
    {
        public int kapiSayisi { get; set; }
        public bool ceker4 { get; set; }
        public bool parkSensoru { get; set; }

        public Otomobil(Marka markası,Vites vitesi,Renk rengi,double _motorHacmi,int kapiSayisi,bool ceker4,bool parkSensoru):base(markası,vitesi,rengi,_motorHacmi)
        {
            this.kapiSayisi = kapiSayisi;
            this.ceker4 = ceker4;
            this.parkSensoru = parkSensoru;
        }

        public void otomobilBilgileriYaz()
        {
            Console.WriteLine("---------------------------------------\nOTOMOBİL BİLGİLERİ\n---------------------------------------");
            Console.WriteLine("Marka:"+marka);
            Console.WriteLine("Vites Tipi:"+vites);
            Console.WriteLine("Aracın Rengi:"+renk);
            Console.WriteLine("Motor Hacmi:" + motorHacmi);
            Console.WriteLine("Arac Kapı Sayısı:" + kapiSayisi);
            Console.WriteLine("Arac 4x4'mü?:" + ceker4);
            Console.WriteLine("Park Sensörü Var mı?:" + parkSensoru);
        }

    }
}
