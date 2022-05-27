using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_8_obiektowka
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("\n-----------Zadanie1----------\n");
			Thread thread = new Thread(() =>
			{
				for (int i = 1; i <= 5; ++i)
				{
					Console.WriteLine("Iteration no. 1: " + i);
					Thread.Sleep(1000); // sleeps created thread for 1 second
				}
			});

			Thread thread2 = new Thread(() =>
			{
				for (int i = 1; i <= 5; ++i)
				{
					Console.WriteLine("Iteration no. 2: " + i);
					Thread.Sleep(1000); // sleeps created thread for 1 second
				}
			});

			thread.Start();
			thread2.Start();
			thread2.Join();



			//Thread.Sleep(1000) - uśpi główny wątek przez 1 sekundę
			//thread.Join() - uśpi główny wątek, dopóki utworzony wątek nie zostanie zakończony

			bool pomoc = true; // zmienna podtrzymujaca
			long liczbaStartowa = 2; // pierwsza mozliwa liczba pierwsza
			HashSet<long> liczbyPierwsze = new HashSet<long>(); // zbio, ktory przychowuje niepowtarzajace sie wartosci
			object zamek = new object(); // zamek, ktory niepozwala dotykac czegos zamknietego

			Console.WriteLine("\n-----------Zadanie3----------\n");

			Thread zadanie3a = new Thread(() => // watek
			{
				while (pomoc == true) // zmienna podtrzymujaca ma wartosc true
				{
					if (CzyPierwsza(liczbaStartowa)) // sprawdzasz czy jakas liczba jest liczba pierwsza
					{
						lock (zamek) // zamykasz zamek
						{
							liczbyPierwsze.Add(liczbaStartowa); // dodajesz do Setu liczbe pierwsza
						}
					}

					liczbaStartowa++; // 2 -> 3 -> 4 -> 5 -> 6 -> 7
				}
			});

			Thread zadanie3b = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
						lock (zamek)
						{
							liczbyPierwsze.Add(liczbaStartowa);
						}
					}

					liczbaStartowa++;
				}
			});

			Thread zadanie3c = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
						lock (zamek)
						{
							liczbyPierwsze.Add(liczbaStartowa);
						}
					}

					liczbaStartowa++;
				}
			});

			Thread zadanie3d = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
						lock (zamek)
						{
							liczbyPierwsze.Add(liczbaStartowa);
						}
					}

					liczbaStartowa++;
				}
			});

			zadanie3a.Start(); // uruchomienie watku nr 3a 5123639 -> 12446512
			zadanie3b.Start(); // uruchomienie watku nr 3b
			zadanie3c.Start();
			zadanie3d.Start();

			Thread.Sleep(1000); // nie przechodzi do nastepnej linii przez 10 sekund
			pomoc = false; // po 10 sekundach przechodimy tutaj

			Console.WriteLine(String.Join(", ", liczbyPierwsze)); // wypisanie calej zawartosci Setu po przecinku
			Console.WriteLine("\n\n\n");












			/*pomoc = true; // zmienna podtrzymujaca
			liczbaStartowa = 2; // pierwsza mozliwa liczba pierwsza
			liczbyPierwsze = new HashSet<long>(); // zbio, ktory przychowuje niepowtarzajace sie wartosci

			Console.WriteLine("\n-----------Zadanie4----------\n");

			Thread zadanie4a = new Thread(() => // watek
			{
				while (pomoc == true) // zmienna podtrzymujaca ma wartosc true
				{
					if (CzyPierwsza(liczbaStartowa)) // sprawdzasz czy jakas liczba jest liczba pierwsza
					{
						liczbyPierwsze.Add(liczbaStartowa); // dodajesz do Setu liczbe pierwsza
					}

					liczbaStartowa++; // 2 -> 3 -> 4 -> 5 -> 6 -> 7
				}
			});

			Thread zadanie4b = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
							liczbyPierwsze.Add(liczbaStartowa);
					}

					liczbaStartowa++;
				}
			});

			Thread zadanie4c = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
							liczbyPierwsze.Add(liczbaStartowa);
					}

					liczbaStartowa++;
				}
			});

			Thread zadanie4d = new Thread(() =>
			{
				while (pomoc == true)
				{
					if (CzyPierwsza(liczbaStartowa))
					{
						liczbyPierwsze.Add(liczbaStartowa);
					}

					liczbaStartowa++;
				}
			});

			zadanie4a.Start(); // uruchomienie watku nr 4a 5123639 -> 12446512
			zadanie4b.Start(); // uruchomienie watku nr 4b
			zadanie4c.Start();
			zadanie4d.Start();

			Thread.Sleep(10000); // nie przechodzi do nastepnej linii przez 10 sekund
			pomoc = false; // po 10 sekundach przechodimy tutaj

			Console.WriteLine(String.Join(", ", liczbyPierwsze)); // wypisanie calej zawartosci Setu po przecinku

			*/
		}

		public static bool CzyPierwsza(long liczba) // funkcja ze strony
		{
			if (liczba < 2)
				return false;

			if (liczba == 2 || liczba == 3)
				return true;

			if (liczba % 2 == 0)
				return false;

			int limit = Convert.ToInt32(Math.Floor(Math.Sqrt(liczba)));

			for (int i = 5, d = 4; i <= limit; i += d)
			{
				if (liczba % i == 0)
				{
					return false;
				}
				d = 6 - d;
			}
			return true;
		}
	}
}
