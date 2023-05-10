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
            Tea tea = new Tea("Mint Chocolate", 5.98, 55, 0, "black");
            Coffee coffee = new Coffee("Dunkin Classic", 2.00, 25, 0, "medium");
            MessageBox.Show(tea.ToString() + " " + coffee.ToString());
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
