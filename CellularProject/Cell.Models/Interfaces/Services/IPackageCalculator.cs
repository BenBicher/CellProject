using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Services
{
    public interface IPackageCalculator
    {
        Package GetOptimalPackage(Line line, List<Package> packages);
    }
}