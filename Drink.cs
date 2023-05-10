using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    abstract internal class Drink : Product
    {
        public enum Size { Short, Tall, Grande, Venti, Trenta }
        Size _drinkSize;

        internal Size DrinkSize { get => _drinkSize; set => _drinkSize = value; }

        public Drink(string name, double price, int points, Size drinkSize) : base (name, price, points)
        {
            _drinkSize = drinkSize;
        } // constructor

        public override string ToString()
        {
            return base.ToString() + $" - {DrinkSize}";
        } // override ToString
    }
}
