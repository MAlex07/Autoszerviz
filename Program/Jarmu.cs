using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzugseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
            SzervizSzugseges = szervizSzugseges;
        }

        public string Rendszam { get => rendszam;
            set{
                if (rendszam == " ")
                {
                    rendszam = "ISMERETLEN";
                }
            } 
                }
        public int Kor { get => kor;
            set { 
            
                if(kor < 0)
                {
                    kor = 0;
                }else if(kor > 50)
                {
                    kor = 50;
                }
            
            } }
        public int KilometerOra { get => kilometerOra;
            set { 
            
                if(kilometerOra < 0)
                {
                    kilometerOra = 0;
                }
            
            } }
        public int UzemanyagSzint { get => uzemanyagSzint; 
            set {
            
                if(uzemanyagSzint < 0)
                {
                    uzemanyagSzint = 0;
                }else if(uzemanyagSzint > 100)
                {
                    uzemanyagSzint = 100;
                }
            
            } }
        public bool SzervizSzugseges { get => szervizSzugseges;
            set {
            
                if(kilometerOra >= 200000)
                {
                    szervizSzugseges = true;
                }
                else
                {
                    szervizSzugseges = false;
                }
            
            } }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{rendszam} - {kor} éves jármű, {kilometerOra} km-rel");
        }

        public virtual void Szervizel(int dij)
        {
            if(dij > 100000)
            {
                kilometerOra -= 10000;
                uzemanyagSzint -= 10;
                Console.WriteLine("A jármű szervizelés megtörtént");
            }
        }



    }
}
