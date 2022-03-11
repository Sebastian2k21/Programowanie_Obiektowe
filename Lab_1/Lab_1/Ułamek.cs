using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
        {
            private int _licznik;
            public int licznik
            {
                get => _licznik;
                set => _licznik = value;
            }
            private int _mianownik;
            private int mianownik
            {
                get => _mianownik;
                set => _mianownik = value;
            }

            public Ulamek() { }
            public Ulamek(int number1, int number2)
            {
                licznik = number1;
                mianownik = number2;
            }

            public int  CompareTo (Ulamek other)
             {
            if (other == null) return -1;
             if (other == this) return 0;

            var diff = this - other;
            if(diff.licznik < 0 && diff.mianownik < 0) return -1;
            if(diff.licznik > 0 && diff.mianownik < 0) return 1;

            return 0;
             }

            public Ulamek(Ulamek prev)
            {
                licznik = prev.licznik;
                mianownik = prev.mianownik;
            }

            public  bool Equals(Ulamek ulamek)
            {
                return ulamek.licznik == licznik && ulamek.mianownik == mianownik;
                if (ulamek == null) return false;
                 if (ulamek == this) return true;
                 return Object.Equals(this.licznik , ulamek.licznik) && Object.Equals(this.mianownik, ulamek.mianownik);
            }

      

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return $"{licznik}/{mianownik}";
            }

        public static Ulamek operator +(Ulamek a,Ulamek b)
        {
            return new Ulamek(a.licznik + b.licznik, a.mianownik);
        }
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik - b.licznik, a.mianownik);
        }
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik, a.mianownik *b.licznik);
        }
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        }
    }
}
