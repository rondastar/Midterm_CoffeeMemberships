using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Tea : Drink
    {
        string _typeOfTea;

        public Tea(string name, double price, int points, Size drinkSize, string typeOfTea) : base(name, price, points, drinkSize)
        {
            _typeOfTea = typeOfTea;
        }
        public string TypeOfTea { get => _typeOfTea; set => _typeOfTea = value; }

        public override string ToString()
        {
            return base.ToString() + $" - {TypeOfTea}";
        }
    }
}
