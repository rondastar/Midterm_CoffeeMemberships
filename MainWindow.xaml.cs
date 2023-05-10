using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// Ronda Rutherford
// May 10, 2023
// CSI 124 Midterm
namespace Midterm_CoffeeMemberships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Test code
            Tea tea = new Tea("Mint Chocolate", 5.98, 55, Drink.Size.Short, "black");
            Coffee coffee = new Coffee("Dunkin Classic", 2.00, 25, Drink.Size.Grande, "medium roast");
            Breakfast breakfast = new Breakfast("Croissanwich", 8.99, 85, true, true);
            Lunch lunch = new Lunch("Sub Sandwich", 9.99, 95, false, false);
            MessageBox.Show(tea.ToString() + " \n" + coffee.ToString() + " \n" + breakfast.ToString() + " \n" + lunch.ToString() + " \nNumber of Products: " + Product.NumberOfProducts);
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMemberInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
