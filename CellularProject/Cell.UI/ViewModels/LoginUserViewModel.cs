using Cell.UI.Pages;
using Cell.UI.ServiceReference;
using Cell.UI.Services;
using Mvvm;
using Mvvm.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Cell.UI.ViewModels
{
    class LoginUserViewModel : BindableBase
    {
        private CRMService _service;

        public DelegateCommand<object> SubmitLogin { get; private set; }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public LoginUserViewModel()
        {
            _service = new CRMService();
            SubmitLogin = new DelegateCommand<object>(_loginUser);
        }

        private async void _loginUser(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;
            if (await _service.LoginUser(_userName, password))
            {
                UserPage userPage = new UserPage();
                MainWindow.MainInstance.NavigationFrame.Navigate(userPage);
            }
            else
            {
                MessageBox.Show("Invalid user name or password.");
                return;
            }
        }
    }
}
