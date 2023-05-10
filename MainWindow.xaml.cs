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
            LinkWindowToData();
            Data.Preload();

        } // MainWindow

        private void LinkWindowToData()
        {
            lbProducts.ItemsSource = Data.Products;
            cbMembers.ItemsSource = Data.Members;
        }
        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow newProductWindow = new ProductWindow();
            newProductWindow.Show();
        } // btnAddNewProduct_Click

        private void btnMemberInfo_Click(object sender, RoutedEventArgs e)
        {
            MemberInformation newMemberWindow = new MemberInformation();
            newMemberWindow.Show();
        } // btnMemberInfo_Click

        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {

        } // btnBuyProduct_Click

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {

        } // btnUsePoints_Click

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        } // cbMembers_SelectionChanged
    }
}
