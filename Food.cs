using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    abstract internal class Food : Product
    {
        bool _isHeated;

        protected Food(string name, double price, int points, bool isHeated) : base(name, price, points)
        {
            _isHeated = isHeated;
        } // constructor
        public bool IsHeated { get => _isHeated; set => _isHeated = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Is heated? {IsHeated}";
        } // override ToString
    }
}
