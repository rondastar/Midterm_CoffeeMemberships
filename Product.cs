using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    abstract internal class Product
    {
        string _name;
        string _sku;
        double _price;
        int _points;
        static int _numberOfProducts = 0;

        protected Product(string name, double price, int points)
        {
            _name = name;
            _price = price;
            _points = points;
            // generate random SKU
            Random rand = new Random();
            _sku = rand.Next(1000000, 10000000).ToString();
            // increase product count
            _numberOfProducts++;
        } // constructor
        public string Name { get => _name; set => _name = value; }
        public string Sku { get => _sku; }
        public double Price { get => _price; set => _price = value; }
        public int Points { get => _points; set => _points = value; }

        public static int NumberOfProducts { get => _numberOfProducts; }

        public override string ToString()
        {
            return $"{GetType().Name} - {Sku} - {Name} - {Price.ToString("c")} - {Points} points";
        } // override ToString

    } // class
} // namespace
