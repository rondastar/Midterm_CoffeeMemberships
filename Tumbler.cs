using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Tumbler : Merchandise
    {
        string _color;
        public Tumbler(string name, double price, int points, string color) : base(name, price, points)
        {
            _color = color;
        } // constructor

        public string Color { get => _color; set => _color = value; }

        public override string ToString()
        {
            return base.ToString() + $" - {Color}";
        } // override ToString
    }
}
