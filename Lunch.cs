using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Lunch : Food
    {
        bool _isCombo;

        public Lunch(string name, double price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            _isCombo = isCombo;
        } // constructor

        public bool IsCombo { get => _isCombo; set => _isCombo = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Is combo? {IsCombo}";
        } // override ToString
    }
}
