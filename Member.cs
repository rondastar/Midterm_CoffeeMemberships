using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Midterm_CoffeeMemberships
{
    abstract internal class Member
    {
        //        - First Name
        string _firstName;
        //- Last Name
        string _lastName;
        //- Member number(a random number between 1000000 and 10000000)
        string _memberNumber;
        //- Point Amount
        int _pointAmount;
        //- Member Since(DateTime object )
        DateTime _memberSince;
        //- Previous Transactions(Observable Collection - Product )
        ObservableCollection<Product> _previousTransactions;
        protected Member(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            // generate random member number
            Random rand = new Random();
            _memberNumber = rand.Next(1000000, 10000000).ToString();
            _pointAmount = 0;
            _memberSince = DateTime.Now;
            _previousTransactions = new ObservableCollection<Product>();
        } // constructor

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string MemberNumber { get => _memberNumber; }
        public int PointAmount { get => _pointAmount; set => _pointAmount = value; }
        public DateTime MemberSince { get => _memberSince; }
        internal ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }

        //        DeductPoints(Product) : Abstract
        abstract public void DeductPoints(Product product);
        //AddPoints(Product) : Abstract
        abstract public void AddPoints(Product product);
        //Public AddProduct(Product) : Add product to previousTransactions Collection
        public void AddProduct(Product product)
        {
            PreviousTransactions.Add(product);
        }
        //Override ToString
        //- GetType() - First Name Last Name - Points(Display Points) - Member Number -–
        public override string ToString()
        {
            return $"{GetType()} - {FirstName} {LastName} - Points: {PointAmount} - Member No.: {MemberNumber} - Member Since: {MemberSince.ToShortDateString}";
        } // override ToString
    }
}
