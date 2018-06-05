using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Managers
{
    public interface IPackageManager
    {
        IEnumerable<Package> GetAllPackages();
        Package GetOptimalPackage(int lineId);
        Package AddPackage(Package package);
        bool UpdatePackage(Package package);
    }
}