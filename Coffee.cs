using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Coffee : Drink
    {
        string _typeOfRoast;

        public Coffee(string name, double price, int points, Size drinkSize, string typeOfRoast) : base(name, price, points, drinkSize)
        {
            _typeOfRoast = typeOfRoast;
        } // constructor
        public string TypeOfRoast { get => _typeOfRoast; set => _typeOfRoast = value; }

        public override string ToString()
        {
            return base.ToString() + $" - {TypeOfRoast}";
        } // override ToString
    }
}
