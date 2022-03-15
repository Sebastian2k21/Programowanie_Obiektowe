using System;
using System.Collections.Generic;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
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
                u3,u2,u1
            };

            ulamkiNieposortowane.Sort();

            for (int i = 0; i < ulamkiNieposortowane.Count; i++)
            {
                Console.WriteLine(ulamkiPosortowane[i].ToString() + " " + ulamkiNieposortowane[i].ToString());
                if (!ulamkiNieposortowane[i].ToString().Equals(ulamkiPosortowane[i].ToString()))
                {
                    czyPosortowane = false;
                }
            }
        }
    }
}
