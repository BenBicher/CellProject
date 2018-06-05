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
using System.Windows;

namespace Cell.UI.ViewModels
{
    class LinePageViewModel : BindableBase
    {
        private ObservableCollection<Client> _Client = new ObservableCollection<Client>();
        private ObservableCollection<Package> _Packages;
        private ObservableCollection<Line> _Lines = new ObservableCollection<Line>();
        private Line _CurrentLine = new Line();
        private CRMService _service;

        public LinePageViewModel()
        {
            _service = new CRMService();
            SubmitDelete = new DelegateCommand(DeleteLine);
            SubmitSave = new DelegateCommand(SaveNewClientLine);
            Load();
        }

        public ObservableCollection<Package> Packages
        {
            get { return _Packages; }
            set { SetProperty(ref _Packages, value); }
        }
        public ObservableCollection<Client> Clients
        {
            get { return _Client; }
            set { SetProperty(ref _Client, value); }
        }

        public ObservableCollection<Line> Lines
        {
            get { return _Lines; }
            set { SetProperty(ref _Lines, value); }
        }

        public Line CurrentLine
        {
            get { return _CurrentLine; }
            set { SetProperty(ref _CurrentLine, value); }
        }

        public DelegateCommand SubmitDelete { get; private set; }
        public DelegateCommand SubmitSave { get; private set; }

        private async void DeleteLine()
        {
            await _service.RemoveClientLine(CurrentLine.Number);
            Navigate();
        }

        private async void SaveNewClientLine()
        {
            CurrentLine.Client = Clients.Where(C => C.ClientId == CurrentLine.ClientId).FirstOrDefault();
            CurrentLine.Packages = Packages.Where(P => P.Id == CurrentLine.PackageId);
            await _service.AddClientLine(CurrentLine, CurrentLine.ClientId);
            Navigate();
        }

        private async void Load()
        {
            Clients = await _service.GetAllClients();
            Lines = await _service.GetAllLines();
            Packages = await _service.GetAllPackages();
        }

        private void Navigate()
        {
            LinePage Page = new LinePage();
            UserPage.UserInstance.UserNavigationFrame.Navigate(Page);
        }
    }
}