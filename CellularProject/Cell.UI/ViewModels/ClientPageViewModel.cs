using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cell.Models.Entities;
using Cell.UI.ServiceReference;
using Mvvm;
using Mvvm.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using Cell.UI.Services;
using Cell.UI.Pages;

namespace Cell.UI.ViewModels
{
    class ClientPageViewModel : BindableBase
    {
        private CRMService _service;
        private ObservableCollection<Client> _Clients;
        private ObservableCollection<ClientType> _ClientTypes;
        private Client _CurrentClient = new Client();
        private ClientType _CurrentClientType = new ClientType();
        public DelegateCommand SubmitDelete { get; private set; }
        public DelegateCommand SubmitNewClient { get; private set; }

        public ClientPageViewModel()
        {
            _service = new CRMService();
            Load();
            SubmitDelete = new DelegateCommand(DeleteClient);
            SubmitNewClient = new DelegateCommand(SaveNewClient);
        }

        public ObservableCollection<Client> Clients
        {
            get { return _Clients; }
            set { SetProperty(ref _Clients, value); }
        }

        public ObservableCollection<ClientType> ClientTypes
        {
            get { return _ClientTypes; }
            set { SetProperty(ref _ClientTypes, value); }
        }
        
        public Client CurrentClient
        {
            get { return _CurrentClient; }
            set { SetProperty(ref _CurrentClient, value); }
        }
        public ClientType CurrentClientTypes
        {
            get { return _CurrentClientType; }
            set { SetProperty(ref _CurrentClientType, value); }
        }

        private async void DeleteClient()
        {
            await _service.RemoveClient(_CurrentClient.ClientId);
            Navigate();
        }

        private async void SaveNewClient()
        {
            _CurrentClient.ClientType = ClientTypes.Where(C => C.Id == _CurrentClient.ClientTypeId).FirstOrDefault();
            await _service.AddClient(_CurrentClient);
            Navigate();
        }

        private async void Load()
        {
            Clients = await _service.GetAllClients();
            ClientTypes = await _service.GetClientTypes();
        }

        private void Navigate()
        {
            ClientPage Page = new ClientPage();
            UserPage.UserInstance.UserNavigationFrame.Navigate(Page);
        }
    }
}