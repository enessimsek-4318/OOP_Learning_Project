using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Odev_2_Ogrenciler
{

    abstract class Ogrenci
    {
        protected string ad_soyad { get; set; }
        protected string okul_numarasi { get; set; }
        public virtual string okul_adi { get; set; } 
        // okul adı girilmediği sürece default olarak açıktan öğrenim yazdırma bunu yapamadım...!
        protected Ogrenim_duzeyi ogrenim_duzeyi { get; set; }
        public abstract double not_ortalamasi { get; set; }
        //public abstract double harf_notu { get; set; } //lise öğrencisi için harf notu yoktur ama  override edilerek lise için geçti kaldı yazacak.
        // harf notu if yapısı oluşturup if içindeki değerleri override edilmiş değerlere ata ekrana yazdır.
        public string ad_soyad_
        {
            get
            {
                return ad_soyad;
            }
            set
            {
                ad_soyad = value;
            }
        }
        public string okul_numarasi_ 
        {
            get 
            {
                return okul_numarasi;
            }
            set
            {
                if (value.Length==11)
                {
                    okul_numarasi=value;
                }
                else
                {
                    Console.WriteLine("Lütfen 11 haneli okul numaranızı Giriniz.");
                }
            } 
        }
        public Ogrenim_duzeyi ogrenim_duzeyi_
        {
            get
            {
                return ogrenim_duzeyi;
            }
            set
            {
                ogrenim_duzeyi = value;
            }
        }

        public Ogrenci()
        {
            this.okul_adi = "Açıktan Eğitim";
        }


        //public abstract void listeye_ekle();  bu metot sonradan kullanılacak........
        //public abstract void bilgileri_yazdir();
        

    }
}
