using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Repositories
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetAllPackages();
        Package AddPackage(Package package);
        bool UpdatePackage(Package package);
    }
}