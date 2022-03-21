using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Product
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public Product(string name)
        {
            this.name = name;

        }
    }
}
