using Cell.Models.Entities;
using Cell.UI.Services;
using Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Data;

namespace Cell.UI.ViewModels
{
    class ClientPropertyPageViewModel : BindableBase
    {
        private CRMService _service;
        public Client _Clients { get; private set; }
        public ClientType _ClientTypes { get; private set; }
        public IEnumerable<Line> _Lines { get; private set; }
        public Package _CurrentPackage = new Package();
        public ObservableCollection<Package> _Package = new ObservableCollection<Package>();

        public ClientPropertyPageViewModel()
        {
            _service = new CRMService();
            Load();
            _Clients = LoginClientViewModel.client;
            _ClientTypes = LoginClientViewModel.client.ClientType;
            _Lines = LoginClientViewModel.client.Lines;
            _CurrentPackage = _Package.Where(P => P.Id == _Lines.Select(l=>l.PackageId).FirstOrDefault()).FirstOrDefault();
        }

        private async void Load()
        {
            _Package = await _service.GetAllPackages();
        }
    }
}
