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

            public Ulamek(Ulamek prev)
            {
                licznik = prev.licznik;
                mianownik = prev.mianownik;
            }

            public virtual bool Equals(Ulamek ulamek)
            {
                return ulamek.licznik == licznik && ulamek.mianownik == mianownik;
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
