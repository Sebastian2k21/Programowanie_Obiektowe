using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace lab_7
{

    public class Program
    {
        public static void Main()
        {
            // Hint: change DESKTOP-123ABC\SQLEXPRESS to your server name
            //       alternatively use localhost or localhost\SQLEXPRESS

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=blogdb;Integrated Security=True";

            using (BloggingContext db = new BloggingContext(connectionString))
            {
                Console.WriteLine($"Database ConnectionString: {db.ConnectionString}.");

                // Create
                Console.WriteLine("Inserting a new entities");


                Role role1 = new Role() // id = 3
                {
                    RoleName = "Administrator"
                };

                User User1 = new User() // id = 2
                {
                    Name = "Sebastian",
                    Surname = "Kaczor",
                    Age = 21,
                    RoleId = 3, // 1

                };

                Task task1 = new Task()
                {
                    TaskName = "Wylej wode",
                    UserId = 2, // 1
                };


                db.Add(role1);
                db.SaveChanges();
                db.Add(User1);
                db.SaveChanges();
                db.Add(task1);
                db.SaveChanges();

                // Read
                Console.WriteLine("Read a user");

                User user = db.Users
                    .OrderBy(A => A.Id)
                    .First();
                Role role = db.Roles
                    .OrderBy(B => B.Id)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");

                //blog.Url = "https://devblogs.microsoft.com/dotnet";

                user.Name = "Krzysztof"; //zmiana imienia user

                user.Tasks.Add(new Task { TaskName = "SPRZĄTANIE SKLEPU Z Ananasami" }); // dodajemy taska do usera
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");

                User lastUser = db.Users
                    .OrderBy(u => u.Id)
                    .Last(); // ?

                db.Remove(lastUser); // user
                //db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}