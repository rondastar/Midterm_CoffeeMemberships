using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class GiftCard : Product
    {
        double _amount;
        protected GiftCard(string name, double price, int points) : base(name, price, points)
        {
            // amount of gift card is same as price
            _amount = price;
        }

        public double Amount { get => _amount; set => _amount = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Amount: {Amount.ToString("c")}";
        }
    }
}
