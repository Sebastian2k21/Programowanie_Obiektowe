using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Meat:Product
    {
        private double weight;
        public double Weight { get => weight; set => weight = value; }

        public Meat(string name, double weight) : base(name)
        { 
            this.weight = weight;
        }

        public override void Print(string prefix)
        {

            base.Print(prefix);
            Console.Write($"{prefix}({weight} kg)\n");
        }
    }
}
