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
using System.Windows.Shapes;

namespace Midterm_CoffeeMemberships
{
    /// <summary>
    /// Interaction logic for MemberInformation.xaml
    /// </summary>
    public partial class MemberInformation : Window
    {
        public MemberInformation()
        {
            InitializeComponent();
            PopulateMemberList();
        }
        private void PopulateMemberList()
        {
            lbMembers.ItemsSource = Data.Members;
        }
        private void lbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbMembers.SelectedIndex;
            Data.UpdateCurrentMember(selectedIndex);
            lbTransactionHistory.ItemsSource = Data.CurrentMember.PreviousTransactions;
        } // lbMembers_SelectionChanged

        private string NewMemberFirstName()
        {
            string firstName = tbFirstName.Text;
            return firstName;
        }
        private string NewMemberLastName()
        {
            string lastName = tbLastName.Text;
            return lastName;
        }
        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            if(rbGoldMember.IsChecked == true)
            {
                GoldMember member = new GoldMember(NewMemberFirstName(), NewMemberLastName());
                Data.AddMemberToCollection(member);
            }
            else if(rbRegularMember.IsChecked == true)
            {
                RegularMember member = new RegularMember(NewMemberFirstName(), NewMemberLastName());
                Data.AddMemberToCollection(member);
            }
            else
            {
                MessageBox.Show("Please select a membership type.");
            }
        }
    }
}
