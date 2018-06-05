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
    public partial class LinePage : Page
    {
        public LinePage()
        {
            //if (LineComboBox.ItemsSource == null)
            //{
            //    LineComboBox.Visibility = Visibility.Collapsed;
            //}
            InitializeComponent();
        }
        private void FavoriteNumber_Checked(object sender, RoutedEventArgs e)
        {
            FavoriteNumberTextBlock.Visibility = Visibility.Visible;
            if (TotalFixedPrice.Visibility == Visibility.Collapsed)
            {
                TotalFixedPrice.Visibility = Visibility.Visible;
            }
        }

        private void FavoriteNumber_Unchecked(object sender, RoutedEventArgs e)
        {
            FavoriteNumberTextBlock.Visibility = Visibility.Collapsed;
            if (TotalFixedPrice.Visibility == Visibility.Visible)
            {
                TotalFixedPrice.Visibility = Visibility.Collapsed;
            }
        }

        private void Friends_Checked(object sender, RoutedEventArgs e)
        {
            FriendsStackPanel.Visibility = Visibility.Visible;
            if (TotalFixedPrice.Visibility == Visibility.Collapsed)
            {
                TotalFixedPrice.Visibility = Visibility.Visible;
            }
        }

        private void Friends_Unchecked(object sender, RoutedEventArgs e)
        {
            FriendsStackPanel.Visibility = Visibility.Collapsed;
            if (TotalFixedPrice.Visibility == Visibility.Visible)
            {
                TotalFixedPrice.Visibility = Visibility.Collapsed;
            }
        }

        private void XminYprice_Checked(object sender, RoutedEventArgs e)
        {
            XminYpriceStackPanel.Visibility = Visibility.Visible;
            if (TotalFixedPrice.Visibility == Visibility.Collapsed)
            {
                TotalFixedPrice.Visibility = Visibility.Visible;
            }
        }

        private void XminYprice_Unchecked(object sender, RoutedEventArgs e)
        {
            XminYpriceStackPanel.Visibility = Visibility.Collapsed;
            if (TotalFixedPrice.Visibility == Visibility.Visible)
            {
                TotalFixedPrice.Visibility = Visibility.Collapsed;
            }
        }
    }
}
