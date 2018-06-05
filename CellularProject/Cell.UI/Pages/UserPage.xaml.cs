using Cell.Models.Entities;
using Cell.UI.ServiceReference;
using Cell.UI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cell.UI.Pages
{
    public partial class UserPage : Page, INotifyPropertyChanged
    {
        static public UserPage UserInstance { get; private set; }
        private string _searchText;
        private ObservableCollection<Client> _Client;
        private CRMService _service;
        public List<string> MyItems { get; set; }

        #region SearchFunc
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged("SearchText");
                OnPropertyChanged("MyFilteredItems");
            }
        }
        public IEnumerable<string> MyFilteredItems
        {
            get
            {
                try
                {
                    MyItems = _Client.Select(c => c.ClientId).ToList();
                    if (SearchText == null) return MyItems;

                    return MyItems.Where(x => x.ToUpper().StartsWith(SearchText.ToUpper()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        #endregion

        private async void GetClients()
        {
            _Client = await _service.GetAllClients();
        }

        public UserPage()
        {
            _service = new CRMService();
            GetClients();
            this.DataContext = this;
            UserInstance = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {

            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void listViewItem1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            UserNavigationFrame.Navigate(clientPage);
        }

        private void listViewItem2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PackagePage packagePage = new PackagePage();
            UserNavigationFrame.Navigate(packagePage);
        }

        private void listViewItem3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LinePage linePage = new LinePage();
            UserNavigationFrame.Navigate(linePage);
        }

        private void listViewItem4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClientTypePage clientPage = new ClientTypePage();
            UserNavigationFrame.Navigate(clientPage);
        }
    }
}