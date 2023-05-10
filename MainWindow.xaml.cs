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

        private void RefreshMemberPointDisplay()
        {
            lblMemberPoints.Content = $"Member Points: {Data.CurrentMember.PointAmount}";
        }
        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedIndex >=0 && cbMembers.SelectedIndex >= 0)
            {
                Member member = Data.CurrentMember;
                Product product = Data.CurrentProduct;
                member.AddProduct(product);
                member.AddPoints(product);
                RefreshMemberPointDisplay();
            }
        } // btnBuyProduct_Click

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {
            if (lbProducts.SelectedIndex >= 0 && cbMembers.SelectedIndex >= 0)
            {
                Member member = Data.CurrentMember;
                Product product = Data.CurrentProduct;
                if(member.PointAmount >= product.Points)
                {
                    member.DeductPoints(product);
                    member.AddProduct(product);
                    RefreshMemberPointDisplay();
                }
                else
                {
                    MessageBox.Show("Point balance is not sufficient for this purchase.");
                }
            }
        } // btnUsePoints_Click

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = cbMembers.SelectedIndex;
            Data.UpdateCurrentMember(selectedIndex);
            RefreshMemberPointDisplay();
            lbTransactions.ItemsSource = Data.CurrentMember.PreviousTransactions;
        } // cbMembers_SelectionChanged

        private void lbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbProducts.SelectedIndex;
            Data.UpdateCurrentProduct(selectedIndex);
        }
    }
}
