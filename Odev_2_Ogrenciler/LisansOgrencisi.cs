using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_Ogrenciler
{
    class LisansOgrencisi : Ogrenci
    {
        public string fakulte { get; set; }
        public double vize { get; set; }
        public double final { get; set; }
        public override double not_ortalamasi { get; set; }

        public LisansOgrencisi(string ad_soyad, string okul_numarasi, string fakulte, Ogrenim_duzeyi ogrenim_duzeyi,double vize,double final)
        {
            this.ad_soyad_ = ad_soyad;
            this.okul_numarasi_ = okul_numarasi;
            this.fakulte = fakulte;
            this.ogrenim_duzeyi = ogrenim_duzeyi;
            this.not_ortalamasi = (vize * 0.4) + (final * 0.6);
        }
        
        public void bilgileri_yazdir(List<LisansOgrencisi> lisansOgrencileri)
        {
            int sayac = 1;
            foreach (LisansOgrencisi item in lisansOgrencileri)
            {
                Console.WriteLine("{0}.ÖĞRENCİ", sayac);
                Console.WriteLine("Adı Soyadı: " + item.ad_soyad);
                Console.WriteLine("Okul Numarası: " + item.okul_numarasi);
                Console.WriteLine("Fakültesi: " + item.fakulte);
                Console.WriteLine("Öğrenim Düzeyi: " + item.ogrenim_duzeyi);
                Console.WriteLine("Not Ortalaması: " + item.not_ortalamasi);
                Console.WriteLine("---------------------------------------");
                sayac++;
            }
        }


    }
}
