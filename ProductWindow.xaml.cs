using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm_CoffeeMemberships
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
            LinkWindowToData();
        }
        private void LinkWindowToData()
        {
            lbProducts.ItemsSource = Data.Products;
            cbSize.ItemsSource = Enum.GetValues(typeof(Drink.Size));
            // presets drink size selected index to 0
            cbSize.SelectedIndex = 0;

        }

        private string NewProductName()
        {
            // returns string in Name text box
            string name = tbName.Text;
            return name;
        }
        private string NewDrinkType()
        {
            // returns string in drink type text box
            string name = tbDrinkType.Text;
            return name;
        }

        private Drink.Size NewDrinkSize()
        {
            int selectedIndex = cbSize.SelectedIndex;
            Drink.Size drinkSize = (Drink.Size)selectedIndex;
            return drinkSize;
        }
        private double NewProductPrice()
        {
            // checks whether entry in price text box can be converted to a double, returns price or displays message and returns -1 if not a positive double.
            bool priceIsDouble = double.TryParse(tbPrice.Text, out double result);
            if (priceIsDouble)
            {
                return result;
            }
            else
            { 
                MessageBox.Show("Please enter a valid price.");
                return -1;
            }
        }
        private int NewProductPoints()
        {
            // checks whether entry in points text box can be converted to an int, returns points as int or displays message  and returns -1 if not a positive int.
            bool pointsIsInt = int.TryParse(tbPoints.Text, out int result);
            if (pointsIsInt && result >= 0)
            {
                return result;
            }
            else
            {
                MessageBox.Show("Please enter a valid point amount.");
                return -1;
            }
        }
        private bool ValidatePriceAndPoints()
        {
            // returns true if both price and points are valid, or false if not.
            if (NewProductPoints() != -1 && NewProductPrice() != -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void RefreshDisplays()
        {
            lbProducts.Items.Refresh();
        }
        private void AddProductToDataCollection(Product product)
        {
            Data.Products.Add(product);
        }

        private bool IsHeated()
        {
            bool isHeated = cbIsHeated.IsChecked.Value;
            return isHeated;
        }
        private bool HasDairyOrIsCombo()
        {
            bool hasDairyOrIsCombo = cbHasDairyOrIsCombo.IsChecked.Value;
            return hasDairyOrIsCombo;
        }
        private string NewMugStyleOrTumblerColor()
        {
            // returns string in drink type text box
            string name = tbColorOrStyle.Text;
            return name;
        }
        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                GiftCard newGiftCard = new GiftCard(NewProductName(), NewProductPrice(), NewProductPoints());
                AddProductToDataCollection(newGiftCard);
                RefreshDisplays();
            }
        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Coffee coffee = new Coffee(NewProductName(), NewProductPrice(), NewProductPoints(), NewDrinkSize(), NewDrinkType());
                AddProductToDataCollection(coffee);
                RefreshDisplays();
            }
        }

        private void btnTea_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Tea tea = new Tea(NewProductName(), NewProductPrice(), NewProductPoints(), NewDrinkSize(), NewDrinkType());
                AddProductToDataCollection(tea);
                RefreshDisplays();
            }
        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Breakfast breakfast = new Breakfast(NewProductName(), NewProductPrice(), NewProductPoints(), IsHeated(), HasDairyOrIsCombo());
                AddProductToDataCollection(breakfast);
                RefreshDisplays();
            }
        }

        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Lunch lunch = new Lunch(NewProductName(), NewProductPrice(), NewProductPoints(), IsHeated(), HasDairyOrIsCombo());
                AddProductToDataCollection(lunch);
                RefreshDisplays();
            }
        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Tumbler tumbler = new Tumbler(NewProductName(), NewProductPrice(), NewProductPoints(), NewMugStyleOrTumblerColor());
                AddProductToDataCollection(tumbler);
                RefreshDisplays();
            }
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePriceAndPoints())
            {
                Mug mug = new Mug(NewProductName(), NewProductPrice(), NewProductPoints(), NewMugStyleOrTumblerColor());
                AddProductToDataCollection(mug);
                RefreshDisplays();
            }
        }
    }
}
