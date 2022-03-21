using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Buyer : Person
    {
        protected List<Product> tasks;
        

        public Buyer(string name, int age) : base(name, age)
        {
            tasks = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            if (index<tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public override void Print(string prefix)
        {
            Console.Write($"{prefix}Buyer: ");
            base.Print(prefix);

            if (tasks.Count > 0)
            {
                Console.WriteLine($"{prefix}{prefix}-- Products: --");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.Write(prefix);
                    tasks[i].Print("\t");
                }
            }

        }
    }
}

