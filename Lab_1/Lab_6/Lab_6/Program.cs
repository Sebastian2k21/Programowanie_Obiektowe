using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6obi

{
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
        public int Age { get; set; }
        public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
        public DateTime? CreatedAt { get; set; }
        public DateTime? RemovedAt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // USERS
            List<User> users = new List<User>()
            {
                new User()
                {
                    Name = "Marek",
                    Role = "ADMIN",
                    Age = 13,
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Marcin",
                    Role = "MODERATOR",
                    Age = 18,
                },
                new User()
                {
                    Name = "Agata",
                    Role = "ADMIN",
                    Age = 21,
                    CreatedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Kamila",
                    Role = "TEACHER",
                    Age = 33,
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Seba",
                    Role = "STUDENT",
                    Age = 13,
                    Marks = new int[5] {5,5,5,3,4 },
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Samira",
                    Role = "STUDENT",
                    Age = 19,
                    Marks = new int[2] {1, 6 },
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Zuzia",
                    Role = "STUDENT",
                    Age = 20,
                    Marks = new int[5] {1,2,3,4,5},
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User() // 8
                {
                    Name = "Zygfryd",
                    Role = "STUDENT",
                    Age = 20,
                    Marks = new int[5] {5,5,3, 3,1},
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Weronika",
                    Role = "STUDENT",
                    Age = 25,
                    Marks = new int[2] {4,2 },
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User() // 10
                {
                    Name = "Wiktoria",
                    Role = "STUDENT",
                    Age = 13,
                    Marks = new int[3] {4,4,4},
                },
                new User()
                {
                    Name = "Krzychu",
                    Role = "STUDENT",
                    Age = 17,
                    Marks = new int[1] {1 },
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Pawel",
                    Role = "STUDENT",
                    Age = 17,
                    Marks = new int[1] {5 },
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Adam",
                    Role = "MODERATOR",
                    Age = 13,
                },
                new User()
                {
                    Name = "Ewelina",
                    Role = "TEACHER",
                    Age = 19,
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Karolina",
                    Role = "STUDENT",
                    Age = 21,
                    Marks = new int[3] {3, 3, 1 },
                    CreatedAt =  new DateTime(2022, 1, 15)
        },
                new User()
                {
                    Name = "Patrycja",
                    Role = "ADMIN",
                    Age = 10,
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Milena",
                    Role = "STUDENT",
                    Age = 16,
                    Marks = new int[5] {5,5,5,3,4 },
                    CreatedAt = new DateTime(2022, 1, 1),
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Kordian",
                    Role = "STUDENT",
                    Age = 20,
                    Marks = new int[10] {5,5,5,5,5,5,5,5,5,4 },
                    CreatedAt = new DateTime(2022, 6, 6),
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Wiktor",
                    Role = "ADMIN",
                    Age = 14,
                    CreatedAt = DateTime.Now,
                    RemovedAt = DateTime.Now,
                },
                new User()
                {
                    Name = "Waclaw",
                    Role = "ADMIN",
                    Age = 73,
                    CreatedAt = DateTime.Now,
                },
            };

            // METHOD-BASED QUERY SYNTAX

            Console.WriteLine("\n----------Zadanie 1 -----------\n");
            var zad1 = users.ToArray().Length;
            Console.WriteLine("1. " + zad1);
            Console.WriteLine("\n----------Zadanie 2 -----------\n");
            var zad2 = users.Select(u => u.Name);
            foreach (var name in zad2)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("\n----------Zadanie 3 -----------\n");
            var zad3 = users.OrderBy(u => u.Name);
            foreach (var user in zad3)
            {
                Console.WriteLine(user.Name);
            }


            Console.WriteLine("\n----------Zadanie 4 -----------\n");
            var zad4 = users.Select(u => u.Role).Distinct(); // Distinct() -> bez powtorzen
            foreach (var role in zad4)
            {
                Console.WriteLine(role);
            }


            Console.WriteLine("\n----------Zadanie 5 -----------\n");
            var zad5 = users.GroupBy(u => u.Role);
            foreach (var group in zad5)
            {
                Console.WriteLine($"====={group.Key}=====");
                foreach (var user in group)
                {
                    Console.WriteLine(user.Name);
                }
            }

            Console.WriteLine("\n\n------\n\n");
            Console.WriteLine("\n----------Zadanie 6-----------\n");
            var zad6 = users.Where(u => u.Marks != null && u.Marks.Length > 0);
            foreach (var user in zad6)
            {
                Console.WriteLine(user.Name + " => " + user.Marks.Length);
            }

            Console.WriteLine("\n\n------\n\n");

            Console.WriteLine("\n----------Zadanie 7-----------\n");

            var zad7a = users.Where(u => u.Marks != null).Sum(u => u.Marks.Sum());
            Console.WriteLine($"Suma ocen to: {zad7a}");
            var zad7b = users.Where(u => u.Marks != null).Sum(u => u.Marks.Count());
            Console.WriteLine($"Ilosc ocen to: {zad7b}");
            //var zad7c = users.Where(u => u.Marks != null).Select(u => u.Marks).Average();
            //Console.WriteLine($"Srednia ocen to: {zad7c}");

            Console.WriteLine("\n----------Zadanie 8 -----------\n");

            var zad8 = users.Where(u => u.Marks != null).Select(u => u.Marks.Max()).Max();
            Console.WriteLine($"Max ocena: {zad8}");

            Console.WriteLine("\n----------Zadanie 9 -----------\n");

            var zad9 = users.Where(u => u.Marks != null).Select(u => u.Marks.Min()).Min();
            Console.WriteLine($"Min ocena: {zad9}");

            Console.WriteLine("\n----------Zadanie 10 -----------\n");

            var zad10 = users.Where(u => u.Marks != null).OrderByDescending(x => x.Marks.Average()).First();
            Console.WriteLine($"Naj uczen: {zad10.Name}");


            Console.WriteLine("\n----------Zadanie 11 -----------\n");


            var zad11 = users.Where(x => x.Marks != null).OrderBy(x => x.Marks.Length).Take(3).ToList();
            Console.WriteLine($"Najmniej ocen maja: ");
            zad11.ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Length})"));

            Console.WriteLine("\n----------Zadanie 12 -----------\n");


            var zad12 = users.Where(x => x.Marks != null).OrderByDescending(x => x.Marks.Length).Take(3).ToList();
            Console.WriteLine($"Najwiecej ocen maja: ");
            zad12.ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Length})"));


            Console.WriteLine("\n----------Zadanie 13 -----------\n");


            var zad13 = users.Where(x => x.Marks != null).Select(x => new { Name = x.Name, Avg = x.Marks.Average() }).ToList();
            Console.WriteLine($"Studenci ze srednia: ");
            zad13.ForEach(x => Console.WriteLine($"{x.Name}: {x.Avg}"));


            Console.WriteLine("\n----------Zadanie 14 -----------\n");


            var zad14 = users.Where(x => x.Marks != null).OrderByDescending(x => x.Marks.Average()).ToList();
            Console.WriteLine($"\nStudenci od najlepszego: ");
            zad14.ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Average()})"));


            Console.WriteLine("\n----------Zadanie 15 -----------\n");


            var zad15 = users.Where(x => x.Marks != null).Select(x => x.Marks.Average()).Sum() / users.Count(x => x.Marks != null);
            Console.WriteLine($"Srednia {zad15}");


            Console.WriteLine("\n----------Zadanie 16 -----------\n");


            var zad16 = users.Where(x => x.CreatedAt != null).GroupBy(x => $"{x.CreatedAt.Value.Year}-{x.CreatedAt.Value.Month:00}");
            Console.WriteLine("Pogrupowanie uzytkownicy po dacie utworzenia (rok miesiac)");
            foreach (var grupa in zad16)
            {
                Console.WriteLine($"Data: {grupa.Key} --------------");
                foreach (var user in grupa)
                {
                    Console.WriteLine(user.Name);
                }
            }
            Console.WriteLine("\n----------Zadanie 17 -----------\n");
            var zad17 = users.Where(x => x.RemovedAt != null).ToList();
            Console.WriteLine("Nieusunieci uzytkownicy:");
            zad17.ForEach(x => Console.WriteLine(x.Name));


            Console.WriteLine("\n----------Zadanie 18 -----------\n");


            var zad18 = users.Where(x => x.Marks != null).OrderByDescending(x => x.CreatedAt).First();
            Console.WriteLine($"Najnowszy student to: {zad18.Name} data: {zad18.CreatedAt}");
            //----------------------------------------------------------------------------------------//
            QuerySyntax(users);
        }

        static void QuerySyntax(List<User> users)
        {
            // QUERY EXPRESSION SYNTAX

            Console.WriteLine("\n----------Zadanie 1 -----------\n");


            var zad1 = (from u in users select u).Count();

            Console.WriteLine($"Ilosc rekordow w tablicy: {zad1}");


            Console.WriteLine("\n----------Zadanie 2 -----------\n");


            var zad2 = from u in users select u.Name;
            Console.WriteLine("Uzytkownicy nazwy:");
            zad2.ToList().ForEach(x => Console.WriteLine(x));


            Console.WriteLine("\n----------Zadanie 3 -----------\n");


            var zad3 = from u in users orderby u.Name select u;

            Console.WriteLine("Uzytkownicy nazwy posortowane:");
            zad3.ToList().ForEach(x => Console.WriteLine(x.Name));


            Console.WriteLine("\n----------Zadanie 4 -----------\n");


            var zad4 = from u in users group u by u.Role into newGroup select newGroup.Key;
            Console.WriteLine("Role: ");
            zad4.ToList().ForEach(x => Console.WriteLine(x));


            Console.WriteLine("\n----------Zadanie 5 -----------\n");


            var zad5 = from u in users group u by u.Role into newGroup select newGroup;
            Console.WriteLine("Uzytkownicy pogrupowani po rolach: ");
            foreach (var group in zad5)
            {
                Console.WriteLine($"====={group.Key}=====");
                foreach (var user in group)
                {
                    Console.WriteLine(user.Name);
                }
            }


            Console.WriteLine("\n----------Zadanie 6 -----------\n");


            var zad6 = (from u in users where u.Marks != null && u.Marks.Length > 0 select u).Count();
            Console.WriteLine($"Ilosc uczniow z jakimikolwiek ocenami: {zad6}");


            Console.WriteLine("\n----------Zadanie 7 -----------\n");


            var zad7a = (from u in users where u.Marks != null select u.Marks.Sum()).Sum();
            Console.WriteLine($"Suma wszystkich ocen to: {zad7a}");

            var zad7b = (from u in users where u.Marks != null select u.Marks.Length).Sum();
            Console.WriteLine($"Ilosc wszystkich ocen to: {zad7b}");
            Console.WriteLine($"Srednia to {zad7a / zad7b}");


            Console.WriteLine("\n----------Zadanie 8 -----------\n");


            var zad8 = (from u in users where u.Marks != null orderby u.Marks.Max() descending select u.Marks.Max()).First();
            Console.WriteLine($"Najwyzsza ocena to: {zad8}");


            Console.WriteLine("\n----------Zadanie 9 -----------\n");


            var zad9 = (from u in users where u.Marks != null orderby u.Marks.Min() select u.Marks.Min()).First();
            Console.WriteLine($"Najnizsza ocena to: {zad9}");


            Console.WriteLine("\n----------Zadanie 10 -----------\n");


            var zad10 = (from u in users where u.Marks != null orderby u.Marks.Average() descending select u).First();
            Console.WriteLine($"Najlepszy student to: {zad10.Name}");

            Console.WriteLine("\n----------Zadanie 11 -----------\n");


            var zad11 = (from u in users where u.Marks != null orderby u.Marks.Length select u).Take(3);
            Console.WriteLine($"Najmniej ocen maja: ");
            zad11.ToList().ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Length})"));


            Console.WriteLine("\n----------Zadanie 12 -----------\n");


            var zad12 = (from u in users where u.Marks != null orderby u.Marks.Length descending select u).Take(3);
            Console.WriteLine($"Najwiecej ocen maja: ");
            zad12.ToList().ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Length})"));


            Console.WriteLine("\n----------Zadanie 13 -----------\n");


            var zad13 = from u in users where u.Marks != null select new { Name = u.Name, Avg = u.Marks.Average() };
            Console.WriteLine($"Studenci ze srednia: ");
            zad13.ToList().ForEach(x => Console.WriteLine($"{x.Name}: {x.Avg}"));


            Console.WriteLine("\n----------Zadanie 14 -----------\n");


            var zad14 = from u in users where u.Marks != null orderby u.Marks.Length descending select u;
            Console.WriteLine($"\nStudenci od najlepszego: ");
            zad14.ToList().ForEach(x => Console.WriteLine($"{x.Name} ({x.Marks.Average()})"));


            Console.WriteLine("\n----------Zadanie 15 -----------\n");


            var zad15 = (from u in users where u.Marks != null select u.Marks.Average()).Sum() / (from u in users where u.Marks != null select u).Count();
            Console.WriteLine($"Srednia {zad15}");


            Console.WriteLine("\n----------Zadanie 16 -----------\n");


            var zad16 = from u in users where u.CreatedAt != null group u by (u.CreatedAt.Value.Year, u.CreatedAt.Value.Month) into gr select gr;
            Console.WriteLine("Pogrupowanie uzytkownicy po dacie utworzenia (rok miesiac)");
            foreach (var grupa in zad16)
            {
                Console.WriteLine($"Data: {grupa.Key} --------------");
                foreach (var user in grupa)
                {
                    Console.WriteLine(user.Name);
                }
            }


            Console.WriteLine("\n----------Zadanie 17 -----------\n");


            var zad17 = from u in users where u.RemovedAt != null select u;
            Console.WriteLine("Nieusunieci uzytkownicy:");
            zad17.ToList().ForEach(x => Console.WriteLine(x.Name));


            Console.WriteLine("\n----------Zadanie 18 -----------\n");


            var zad18 = (from u in users where u.Marks != null orderby u.CreatedAt descending select u).First();
            Console.WriteLine($"Najnowszy student to: {zad18.Name} data: {zad18.CreatedAt}");
        }
    }
}
