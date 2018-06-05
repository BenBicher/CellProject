using Cell.Models.Entities;
using Cell.UI.Pages;
using Cell.UI.Services;
using Mvvm;
using Mvvm.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Cell.UI.ViewModels
{
    class ClientTypePageViewModel : BindableBase, INotifyPropertyChanged
    {
        private ObservableCollection<ClientType> _ClientTypes;
        private ClientType _CurrentClientType = new ClientType();
        private CRMService _service;

        public DelegateCommand SubmitSave { get; private set; }
        public DelegateCommand SubmitUpdate { get; private set; }
        public DelegateCommand SubmitDelete { get; private set; }

        public ClientTypePageViewModel()
        {
            _service = new CRMService();
            SubmitSave = new DelegateCommand(SaveNewClientType);
            SubmitUpdate = new DelegateCommand(UpdateClientType);
            SubmitDelete = new DelegateCommand(DeleteClientType);
            LoadClientTypess();
        }

        public ObservableCollection<ClientType> ClientTypes
        {
            get { return _ClientTypes; }
            set { SetProperty(ref _ClientTypes, value); }
        }

        public ClientType ClientType
        {
            get { return _CurrentClientType; }
            set { SetProperty(ref _CurrentClientType, value); }
        }

        private async void SaveNewClientType()
        {
            await _service.AddClientType(_CurrentClientType);
            Navigate();
        }

        private async void UpdateClientType()
        {
            await _service.UpdateClientType(_CurrentClientType);
            Navigate();
        }

        private async void DeleteClientType()
        {
            await _service.RemoveClientType(_CurrentClientType);
            Navigate();
        }

        private async void LoadClientTypess()
        {
            ClientTypes = await _service.GetClientTypes();
        }

        private void Navigate()
        {
            ClientTypePage clientPage = new ClientTypePage();
            UserPage.UserInstance.UserNavigationFrame.Navigate(clientPage);
        }
    }
}