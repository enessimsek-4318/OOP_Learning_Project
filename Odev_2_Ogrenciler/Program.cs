using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Odev_2_Ogrenciler
{
    enum Ogrenim_duzeyi
    {
        IlkOgretim, Ortaogretim, Lise, Lisans
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<LiseOgrencisi> liseOgrencileri = new List<LiseOgrencisi>();
            List<LisansOgrencisi> lisansOgrencileri = new List<LisansOgrencisi>();
            LiseOgrencisi liseOgrencisi = new LiseOgrencisi("enes","16050611064","esentepe mumcular",Ogrenim_duzeyi.Lise,50,55);
            liseOgrencileri.Add(liseOgrencisi);
            LisansOgrencisi lisansOgrencisi = new LisansOgrencisi("ihsan", "16050615555", "Mühendislik Fakültesi", Ogrenim_duzeyi.Lisans, 50, 55);
            lisansOgrencileri.Add(lisansOgrencisi);
            lisansOgrencisi.bilgileri_yazdir(lisansOgrencileri);
            liseOgrencisi.bilgileri_yazdir(liseOgrencileri);
            Console.ReadLine();
        }
    }
}
