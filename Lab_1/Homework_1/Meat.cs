using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Meat
    {
        private double weight;
        public double Weight { get => weight; set => weight = value; }

        public Meat(string name, double weight)
        {
            name = name;

            this.weight = weight;

        }
    }
}
