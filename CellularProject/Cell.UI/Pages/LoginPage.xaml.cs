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

namespace Cell.UI.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            LoginUser LoginPage = new LoginUser();
            this.NavigationService.Navigate(LoginPage);
        }

        private void ClientButton_Click(object sender, RoutedEventArgs e)
        {
            LoginClient LoginPage = new LoginClient();
            this.NavigationService.Navigate(LoginPage);
        }
    }
}
