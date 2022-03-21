using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Shop
    {
        private string name;
        private Person[] people;
        private Product[] products;
        public string Name { get => name; set => name = value; }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            return;
        }
    }
}

