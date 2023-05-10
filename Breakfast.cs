using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Breakfast : Food
    {
        bool _hasDairy;

        public Breakfast(string name, double price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            _hasDairy = hasDairy;
        } // constructor

        public bool HasDairy { get => _hasDairy; set => _hasDairy = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Has dairy? {HasDairy}";
        } // override ToString
    }
}
