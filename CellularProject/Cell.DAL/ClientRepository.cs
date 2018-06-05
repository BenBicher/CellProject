using Cell.Models.Entities;
using Cell.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cell.DAL.Helpers;
using Cell.DAL.Models;

namespace Cell.DAL
{
    public class ClientRepository : IClientRepository
    {
        public Client AddClient(Client client)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientDb newClient = client.FromDTO();
                    db.Clients.Add(newClient);
                    db.Entry(newClient).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return newClient.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public Line AddClientLine(Line line, string clientId)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    LineDb newLine = line.FromDTO();
                    newLine.ClientId = clientId;
                    newLine = db.Lines.Add(newLine);
                    db.Entry(newLine).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return newLine.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<Client> GetAllClients()
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    IEnumerable<ClientDb> allClients = db.Clients.Include("Lines").Include("ClientType").ToList();
                    return allClients.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<Line> GetAllLines()
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    IEnumerable<LineDb> allLines = db.Lines.ToList();
                    return allLines.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public Line GetLine(int lineId)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    LineDb selectedLine = db.Lines.SingleOrDefault(s => s.Id == lineId);
                    return selectedLine.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public Client LoginClient(string clientId, string contactNumber)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientDb client = db.Clients.Include("Lines").Include("ClientType").ToList().Where(c => c.ClientId == clientId)
                        .Where(c => c.Lines.Select(L=>L.Number == contactNumber).FirstOrDefault()).FirstOrDefault();
                    return client.ToDTO();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool RemoveClient(string clientId)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientDb clientToRemove = db.Clients.SingleOrDefault(c => c.ClientId == clientId);
                    db.Clients.Remove(clientToRemove);
                    db.Entry(clientToRemove).State = System.Data.Entity.EntityState.Deleted;
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

        public bool RemoveClientLine(string number)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    LineDb lineToRemove = db.Lines.SingleOrDefault(l => l.Number == number);
                    db.Lines.Remove(lineToRemove);
                    db.Entry(lineToRemove).State = System.Data.Entity.EntityState.Deleted;
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

        public bool UpdateClient(Client client)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    ClientDb clientToUpdate = db.Clients.SingleOrDefault(c => c.ClientId == client.ClientId);
                    db.Entry(client).State = System.Data.Entity.EntityState.Modified;
                    clientToUpdate = client.FromDTO();
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

        public bool UpdateClientLine(Line line)
        {
            using (var db = new CellDbContext())
            {
                try
                {
                    LineDb lineToUpdate = db.Lines.SingleOrDefault(l => l.ClientId == line.ClientId);
                    db.Entry(lineToUpdate).State = System.Data.Entity.EntityState.Modified;
                    lineToUpdate = line.FromDTO();
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