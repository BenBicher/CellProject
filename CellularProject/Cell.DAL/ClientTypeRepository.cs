using Cell.DAL.Helpers;
using Cell.DAL.Models;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cell.DAL
{
    public class ClientTypeRepository : IClientTypeRepository
    {
        public ClientType AddClientType(ClientType clientType)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientTypeDb newType;
                    ClientTypeDb typeDb = clientType.FromDTO();
                    newType = db.ClientTypes.Add(typeDb);
                    db.Entry(newType).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return newType.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<ClientType> GetAllClientTypes()
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    IEnumerable<ClientTypeDb> allClientTypes = db.ClientTypes.Include("Clients").ToList();
                    return allClientTypes.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool RemoveClientType(ClientType clientType)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientTypeDb typeToRemove = db.ClientTypes.Where(c => c.TypeName == clientType.TypeName).FirstOrDefault();
                    typeToRemove.ToDTO();
                    db.ClientTypes.Remove(typeToRemove);
                    db.Entry(typeToRemove).State = System.Data.Entity.EntityState.Deleted;
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

        public bool UpdateClientType(ClientType clientType)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientTypeDb TypeToUpdate = db.ClientTypes.Where(c => c.TypeName == clientType.TypeName).FirstOrDefault();
                    TypeToUpdate.ToDTO();
                    db.Entry(TypeToUpdate).State = System.Data.Entity.EntityState.Modified;
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