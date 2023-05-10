using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CoffeeMemberships
{
    internal class RegularMember : Member
    {

        protected RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        //        Override DeductPoints(Product)
        //Deduct the products points from the member
        override public void DeductPoints(Product product)
        {
            PointAmount -= product.Points;    
        }

        //Override AddPoints(Product) : Abstract
        //Add the products points for the member
        public override void AddPoints(Product product)
        {
            PointAmount += product.Points;
        }
    }
}
