using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
        /// <summary>
        /// Klasa Ulamek przedstawia ulamek w programie
        /// </summary>
        public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
        {
        /// <summary>
        /// pole
        /// </summary>
            private int _licznik;
        /// <summary>
        /// wlasciwosc
        /// </summary>
            public int licznik
            {
                get => _licznik;
                private set => _licznik = value;
            }
        /// <summary>
        /// pole przedstawiajaca mianownik ulamka
        /// </summary>
            private int _mianownik;

        /// <summary>
        /// wlasciwosc  mianownik ulamka
        /// </summary>
            public int mianownik
            {
                get => _mianownik;
                private set => _mianownik = value;
            }

            /// <summary>
            /// konstruktor bezparametrowy
            /// </summary>
            public Ulamek() { }

            /// <summary>
            /// konstrukto 2-argumentowy
            /// </summary>
            /// <param name="number1">licznik ulamka</param>
            /// <param name="number2">mianownik ulamka</param>
            public Ulamek(int number1, int number2)
            {
                licznik = number1;
                mianownik = number2;
            }

            /// <summary>
            /// Porownuje obiekty typu Ulamek
            /// </summary>
            /// <param name="other">Ulamek do porownania</param>
            /// <returns>zwraca wiekszy ulamek</returns>
            public int CompareTo (Ulamek other)
             {
            if (other == null) return -1;
             if (other == this) return 0;

            var diff = this - other;
            if(diff.licznik < 0) return -1;
            if(diff.licznik > 0) return 1;

            return 0;
             }

        /// <summary>
        /// konstruktor kopiujacy
        /// </summary>
        /// <param name="prev">Ulamek do skopiowania</param>
            public Ulamek(Ulamek prev)
            {
                licznik = prev.licznik;
                mianownik = prev.mianownik;
            }

        /// <summary>
        /// metoda zaokragla ulamke w dol
        /// </summary>
        /// <returns>zwraca zaookraglana wartosc</returns>
        public int ZaokraglijWDol() // 2/4 -> 0.50
        {
            return (int)Math.Floor(((double)licznik / (double)mianownik)); // 0 -> 0.0000 -> 0
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ZaokraglijWGore() // 2/4 -> 0.50
        {
            return (int)Math.Ceiling(((double)licznik / (double)mianownik));
        }

        /// <summary>
        /// sprawdza czy ulamki sa sobie rowne
        /// </summary>
        /// <param name="ulamek">Ulamek do porownania</param>
        /// <returns>true jezeli ulamki sa rowne, w przeciwnym razie false</returns>
        public  bool Equals(Ulamek ulamek)
            {
                return ulamek.licznik == licznik && ulamek.mianownik == mianownik;
                if (ulamek == null) return false;
                 if (ulamek == this) return true;
                 return Object.Equals(this.licznik , ulamek.licznik) && Object.Equals(this.mianownik, ulamek.mianownik);
            }

            
        /// <summary>
        /// wyswietla ulamek w czytelnej formie
        /// </summary>
        /// <returns>zwraca czytelna forme ulamka</returns>
            public override string ToString()
            {
                return $"{licznik}/{mianownik}";
            }

        /// <summary>
        /// przeładowanie operatora +
        /// </summary>
        /// <param name="a">pierwszy ulamek</param>
        /// <param name="b">drugi ulamek</param>
        /// <returns>sume ulamkow</returns>
        public static Ulamek operator +(Ulamek a,Ulamek b)
        {
            return new Ulamek(a.licznik + b.licznik, a.mianownik);
        }
        /// <summary>
        /// przeładowanie operatora - 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>różnica ułamków</returns>
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik - b.licznik, a.mianownik);
        }
        /// <summary>
        /// przeładowanie operatora "/"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>dzielenie ułamków</returns>
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik, a.mianownik *b.licznik);
        }
        /// <summary>
        /// przeładowanie operatora "*"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>mnożenie ułamków</returns>
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        }
    }
}
