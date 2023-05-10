using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class GoldMember : Member
    {

        protected GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        //        Override DeductPoints(Product)
        // Deduct HALF the products points - 50 from the member
        override public void DeductPoints(Product product)
        {
            PointAmount -= (product.Points / 2 - 50);
        }

        //Override AddPoints(Product) : Abstract
        //Add the products points + 50 for the member
        public override void AddPoints(Product product)
        {
            PointAmount += (product.Points + 50);
        }
    }
}
