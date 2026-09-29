using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomány;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomány): base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomány = rakomány;
        }

        public int Rakomány { get => rakomány; 
            set { 
            
                if(rakomány < 0)
                {
                    rakomány = 0;

                }else if(rakomány > 20){
                    
                    rakomány = 20;
                }

            } }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves teherautó, {KilometerOra} km-rel, {rakomány} tonna rakománnyal");
        }

        public override void Szervizel(int dij)
        {
            rakomány = 0;

        }
    }
}
