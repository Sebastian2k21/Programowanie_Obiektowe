using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Ulamek
    {
        private int Licznik { get; set; }
        private int Mianownik { get; set; }

        public Ulamek()
        {

        }

        public Ulamek (int numer1,int numer2)
        {
            Licznik = numer1;
            Mianownik = numer2;
        }

        public Ulamek(Ulamek prev)
        {
            Licznik = prev.Licznik;
            Mianownik = prev.Mianownik;
        }

        public override string ToString()
        {
            return $"{Licznik} / {Mianownik}";
        }

        public static Ulamek operator +(Ulamek a,Ulamek b)
        {
            return new Ulamek(a.Licznik + b.Licznik, a.Mianownik);
        }
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik - b.Licznik, a.Mianownik);
        }
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik * b.Mianownik, a.Mianownik *b.Licznik);
        }
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.Licznik * b.Licznik, a.Mianownik * b.Mianownik);
        }
    }
}
