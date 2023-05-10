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
            LinkWindowToData();
        }
        private void LinkWindowToData()
        {
            lbMembers.ItemsSource = Data.Members;
        }
        private void lbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        } // lbMembers_SelectionChanged
    }
}
