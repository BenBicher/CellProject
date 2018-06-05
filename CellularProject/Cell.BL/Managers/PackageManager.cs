using Cell.BL.Services;
using Cell.DAL;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Managers;
using Cell.Models.Interfaces.Repositories;
using Cell.Models.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.BL.Managers
{
    public class PackageManager : IPackageManager
    {
        private IClientRepository _clientRepo;
        private IPackageRepository _packageRepository;
        private IPackageCalculator _packageCalculator;

        public PackageManager()
        {
            _clientRepo = new ClientRepository();
            _packageRepository = new PackageRepository();
            _packageCalculator = new PackageCalculator();
        }

        public PackageManager(IClientRepository clientRepository, IPackageRepository packageRepository, IPackageCalculator packageCalculator)
        {
            _clientRepo = clientRepository;
            _packageRepository = packageRepository;
            _packageCalculator = packageCalculator;
        }

        public Package AddPackage(Package package)
        {
            return _packageRepository.AddPackage(package);
        }

        public IEnumerable<Package> GetAllPackages()
        {
            return _packageRepository.GetAllPackages();
        }

        public Package GetOptimalPackage(int lineId)
        {
            List<Package> packages = new List<Package>(_packageRepository.GetAllPackages());
            Line line = _clientRepo.GetLine(lineId);
            return _packageCalculator.GetOptimalPackage(line, packages);
        }

        public bool UpdatePackage(Package package)
        {
            return _packageRepository.UpdatePackage(package);
        }
    }
}