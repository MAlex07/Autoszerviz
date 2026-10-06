using System;
using System.Collections.Generic;
using System.Text;

namespace Autoszerviz
{
    public class Busz : Jarmu
    {
        private int utasok;

        public Busz(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int utasok): base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Utasok = utasok;
        }

        public int Utasok { get => utasok; 
            set { 
                if(value < 0)
                {
                    value = 0;
                }else if(value > 50)
                {
                    value = 50;
                }
            
            } }


        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel, {utasok} utas utazik rajta");
        }

        public override void Szervizel(int dij)
        {
            utasok = 0;
            base.Szervizel(dij);
        }
    }
}
