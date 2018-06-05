using Cell.Models.Entities;
using Cell.UI.Pages;
using Cell.UI.Services;
using Mvvm;
using Mvvm.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.UI.ViewModels
{
    class PackagePageViewModel : BindableBase
    {
        private ObservableCollection<Line> _Lines;
        private ObservableCollection<Package> _Packages;
        private Package _CurrentPackage = new Package();
        private CRMService _service;
        public DelegateCommand SubmitSave { get; private set; }

        public PackagePageViewModel()
        {
            _service = new CRMService();
            SubmitSave = new DelegateCommand(SaveNewPackage);
            Load();
        }

        public ObservableCollection<Package> Packages
        {
            get { return _Packages; }
            set { SetProperty(ref _Packages, value); }
        }

        public Package CurrentPackage
        {
            get { return _CurrentPackage; }
            set { SetProperty(ref _CurrentPackage, value); }
        }
        public ObservableCollection<Line> Lines
        {
            get { return _Lines; }
            set { SetProperty(ref _Lines, value); }
        }
        private async void SaveNewPackage()
        {
            await _service.AddPackage(_CurrentPackage);
            Navigate();
        }
        private async void Load()
        {
            Packages = await _service.GetAllPackages();
            Lines = await _service.GetAllLines();
        }

        private void Navigate()
        {
            PackagePage Page = new PackagePage();
            UserPage.UserInstance.UserNavigationFrame.Navigate(Page);
        }
    }
}
