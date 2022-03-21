using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Fruit
    {
        private int count;
        public int Count { get => count; set => count = value; }

        public Fruit(string name, int count)
        {
            this.name = name;
            this.Count = count;
        }

    }
}
