using Cell.DAL.Helpers;
using Cell.DAL.Models;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cell.DAL
{
    public class PackageRepository : IPackageRepository
    {
        public Package AddPackage(Package package)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    PackageDb newPackage;
                    PackageDb packageDb = package.FromDTO();
                    newPackage = db.Packages.Add(packageDb);
                    db.Entry(package).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return newPackage.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<Package> GetAllPackages()
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    IEnumerable<PackageDb> allPackages = db.Packages.Include("PackageIncludes").ToList();
                    return allPackages.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool UpdatePackage(Package package)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    PackageDb packageToUpdate = db.Packages.SingleOrDefault(p => p.Id == package.Id);
                    db.Entry(package).State = System.Data.Entity.EntityState.Modified;
                    packageToUpdate = package.FromDTO();
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}