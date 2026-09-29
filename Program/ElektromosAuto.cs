using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int akkumulatorSzint): base(rendszam, kor, kilometerOra, 0)
        {
            AkkumulatorSzint = akkumulatorSzint;
            
        }

        public int AkkumulatorSzint { get => akkumulatorSzint; 
            set {
            
                if (akkumulatorSzint < 0)
                {
                    akkumulatorSzint = 0;
                }else if(akkumulatorSzint > 100)
                {
                    akkumulatorSzint = 100;
                }
            
            } }


        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves autó, {KilometerOra} km-rel, {akkumulatorSzint}%");
        }

        public override void Szervizel(int dij)
        {
            if(dij > 100000)
            {
                KilometerOra -= 10000;
                akkumulatorSzint -= 20;
                Console.WriteLine("A jármű szervizelése megtörtént");
            }
        }
    }
}
