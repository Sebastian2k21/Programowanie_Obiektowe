using NUnit.Framework;
using Lab_1;
using System.Collections.Generic;

namespace Lab_1.Test
{
    public class Tests
    {
        // pierwszy test
        [Test]
        public void KonstruktorKopiujacyTest()
        {
            Ulamek u1 = new Ulamek(2, 4);
            Ulamek u2 = new Ulamek(u1);

            Assert.IsTrue(u1.Equals(u2));

            //if (u1.Equals(u2) == true) ;
                // zdaje test
        }

        // drugi test
        [Test]
        public void MetodaToStringTest()
        {
            // tworzysz zmienne
            Ulamek liczba = new Ulamek(2, 4);
            string oczekiwanyWynik = "2/4";

            // wywolujesz funkcje, ktora chcesz stestowac i jej wynik zapisujesz
            string wynikZMetody = liczba.ToString();

            // sprawdzasz czy wyniki sa takie same
            Assert.IsTrue(wynikZMetody == oczekiwanyWynik);
        }

        // trzeci test
        [Test]
        public void PrzeladowaniePlusTest()
        {
            Ulamek u1 = new Ulamek(2, 4);
            Ulamek u2 = new Ulamek(5, 4);
            Ulamek oczekiwanyWynik = new Ulamek(7, 4);

            Ulamek wynik = u1 + u2;

            Assert.IsTrue(wynik.ToString() == oczekiwanyWynik.ToString());
        }

        [Test]
        public void SortowanieUlamkowTest()
        {
            bool czyPosortowane = true;
            Ulamek u1 = new Ulamek(1, 4);
            Ulamek u2 = new Ulamek(2, 4);
            Ulamek u3 = new Ulamek(3, 4);

            List<Ulamek> ulamkiNieposortowane = new List<Ulamek>()
            {
                u2,
                u3,
                u1
            };

            List<Ulamek> ulamkiPosortowane = new List<Ulamek>()
            {
                u1,
                u2,
                u3
            };

            ulamkiNieposortowane.Sort();

            for (int i = 0; i < ulamkiNieposortowane.Count; i++)
            {
                if (!ulamkiNieposortowane[i].ToString().Equals(ulamkiPosortowane[i].ToString()))
                {
                    czyPosortowane = false;
                    break;
                }
            }


            Assert.IsTrue(czyPosortowane);
        }

        // szosty
        [Test]
        public void ZaokraglijWGoreTest()
        {
            Ulamek u1 = new Ulamek(13, 2);
            int oczekiwanyWynik = 7;

            int wynikZMetody = u1.ZaokraglijWGore();

            Assert.IsTrue(oczekiwanyWynik == wynikZMetody);
        }
    }
}