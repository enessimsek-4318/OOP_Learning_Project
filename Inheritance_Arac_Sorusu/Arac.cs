using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Arac_Sorusu
{
    class Arac
    {
        public Marka marka { get; set; }
        public Vites vites { get; set; }
        public Renk renk { get; set; }
        public double motorHacmi { get; set; }


        public Arac(Marka marka,Vites vites,Renk renk,double motorHacmi)
        {
            this.marka = marka;
            this.vites = vites;
            this.renk = renk;
            this.motorHacmi = motorHacmi;
        }
    }
}
