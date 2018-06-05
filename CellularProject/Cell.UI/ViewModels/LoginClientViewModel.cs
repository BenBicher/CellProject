using Cell.Models.Entities;
using Cell.UI.Pages;
using Cell.UI.ServiceReference;
using Cell.UI.Services;
using Mvvm;
using Mvvm.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Cell.UI.ViewModels
{
    public class LoginClientViewModel : BindableBase
    {
        static public Client client { get; private set; }
        public DelegateCommand SubmitLogin { get; private set; }
        private CRMService _service;
        private string _clientId;
        private string _contactNumber;

        public LoginClientViewModel()
        {
            SubmitLogin = new DelegateCommand(_loginClient);
            _service = new CRMService();
        }

        public string ContactNumber
        {
            get { return _contactNumber; }
            set { SetProperty(ref _contactNumber, value); }
        }

        public string ClientId
        {
            get { return _clientId; }
            set { SetProperty(ref _clientId, value); }
        }

        private async void _loginClient()
        {
            client = await _service.LoginClient(_clientId, _contactNumber);
            ClientPropertyPage clientPage = new ClientPropertyPage();
            MainWindow.MainInstance.NavigationFrame.Navigate(clientPage);
        }
    }
}