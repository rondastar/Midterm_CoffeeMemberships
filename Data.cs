using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Midterm_CoffeeMemberships
{
    internal class Data
    {
        //        STATIC Fields
        //- Observable Collection for Member
        static ObservableCollection<Member> _members;
        //- Oberserable Collection for Products
        static ObservableCollection<Product> _products;
        //- currentProduct = null -- WHAT DOES THIS MEAN??
        static Product _currentProduct = null;
        //- current Member = null -- WHAT DOES THIS MEAN??
        static Member _currentMember = null;

        static Data()
        {
            //STATIC Constructor
            //- Initialize both observable collections here
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>();
        } //STATIC Constructor

        //STATIC Property(All sets done by methods )
        public static ObservableCollection<Member> Members { get => _members; }
        public static ObservableCollection<Product> Products { get => _products; }
        public static Product CurrentProduct { get => _currentProduct; }
        public static Member CurrentMember { get => _currentMember; }

        //        STATIC Methods
        public static void AddProductToCollection(Product product)
        {
            Products.Add(product);
        }

        public static void AddMemberToCollection(Member member)
        {
            Members.Add(member);
        }
        public static void UpdateCurrentProduct(int productIndex)
        {
            _currentProduct = Products[productIndex];
        }

        public static void UpdateCurrentMember(int memberIndex)
        {
            _currentMember = Members[memberIndex];
        }

        public static void Preload()
        {
            // Preload
            Tea tea = new Tea("Mint Chocolate", 5.98, 550, Drink.Size.Short, "black");
            Coffee coffee = new Coffee("Dunkin Classic", 2.00, 250, Drink.Size.Grande, "medium roast");
            Breakfast breakfast = new Breakfast("Croissanwich", 8.99, 850, true, true);
            Lunch lunch = new Lunch("Sub Sandwich", 9.99, 950, false, false);
            GiftCard gc = new GiftCard("Gift Card", 500, 500);
            Mug mug = new Mug("Coffee Mug", 12.99, 1250, "coffee beans");
            Tumbler tumbler = new Tumbler("Tall Tumbler", 9.99, 1000, "clear");
            AddProductToCollection(tea);
            AddProductToCollection(coffee);
            AddProductToCollection(breakfast);
            AddProductToCollection(lunch);
            AddProductToCollection(gc);
            AddProductToCollection(mug);
            AddProductToCollection(tumbler);
            RegularMember rm = new RegularMember("Ronda", "Rutherford");
            GoldMember gm = new GoldMember("Carol", "Goodner");
            AddMemberToCollection(rm);
            AddMemberToCollection(gm);
            gm.PreviousTransactions.Add(tea);
        }

        //Your data class is vital to your project.All listboxes or combo boxes that need to display products or
        //members should be connected to the collections here. MAKE SURE TO USE selectionBox.ItemsSource =
        //CollectionName to make your life easier.
        //All Properties should be static, and only have getters.Adding anything to your fields should be done
        //with methods.

    }
}
