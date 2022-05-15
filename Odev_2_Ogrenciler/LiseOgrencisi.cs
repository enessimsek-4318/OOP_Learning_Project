using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_Ogrenciler
{
    class LiseOgrencisi : Ogrenci
    {
        public override string okul_adi { get; set; }
        public double not_1 { get; set; }
        public double not_2 { get; set; }
        public override double not_ortalamasi { get; set; }

        public LiseOgrencisi(string ad_soyad,string okul_numarasi,string okul_adi,Ogrenim_duzeyi ogrenim_duzeyi,double not_1,double not_2)
        {
            this.ad_soyad_ = ad_soyad;
            this.okul_numarasi_ = okul_numarasi;
            this.okul_adi = okul_adi;
            this.ogrenim_duzeyi = ogrenim_duzeyi;
            this.not_ortalamasi = (not_1 + not_2) / 2;
        }

        
       
        
        public void bilgileri_yazdir(List<LiseOgrencisi> liseOgrencileri)
        {
            int sayac = 1;
            foreach (LiseOgrencisi item in liseOgrencileri)
            {
                Console.WriteLine("{0}.ÖĞRENCİ",sayac);
                Console.WriteLine("Adı Soyadı: "+item.ad_soyad);
                Console.WriteLine("Okul Numarası: "+item.okul_numarasi);
                Console.WriteLine("Okul Adı: "+item.okul_adi);
                Console.WriteLine("Öğrenim Düzeyi: "+item.ogrenim_duzeyi);
                Console.WriteLine("Not Ortalaması: "+item.not_ortalamasi);
                Console.WriteLine("---------------------------------------");
                sayac++;
            }
           
            
        }

    }
}
