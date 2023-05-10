using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class Mug : Merchandise
    {
        string _design;
        protected Mug(string name, double price, int points, string design) : base(name, price, points)
        {
            _design = design;
        } // constructor

        public string Design { get => _design; set => _design = value; }

        public override string ToString()
        {
            return base.ToString() + $" - {Design}";
        } // override ToString
    }
}
