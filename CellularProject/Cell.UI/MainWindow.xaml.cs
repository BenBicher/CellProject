using System;
using System.Windows;
using System.Windows.Controls;
using Cell.Host;
using Cell.UI.Pages;

namespace Cell.UI
{
    public partial class MainWindow : Window
    {
        static public MainWindow MainInstance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            MainInstance = this;
            LoginPage loginPage = new LoginPage();
            NavigationFrame.Navigate(loginPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
