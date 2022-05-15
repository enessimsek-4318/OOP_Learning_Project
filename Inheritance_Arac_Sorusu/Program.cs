using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Arac_Sorusu
{
    enum Marka
    {
        Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo
    }
    enum Vites 
    {
        Manuel, Otomatik, YariOtomatik
    }
    enum Renk 
    {
        Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor
    }


    class Program
    {
        static void Main(string[] args)
        {


            Otomobil otomobil = new Otomobil(Marka.Mercedes,Vites.Otomatik,Renk.Mavi, 2.2, 2, true, true);
            Ticari ticari = new Ticari(Marka.Scania,Vites.Manuel,Renk.Mavi,5.2,25,true,2);
            otomobil.otomobilBilgileriYaz();
            ticari.ticariBilgileriYaz();
            Console.ReadLine();
        }
    }
}
