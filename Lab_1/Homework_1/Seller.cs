using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Seller:Person 
    {
        public Seller(string name, int age) : base(name, age) { }
        
        public override void Print(string prefix)
        {
            Console.Write($"{prefix}Seller: ");
            base.Print(prefix);
        }
        


    }
}
