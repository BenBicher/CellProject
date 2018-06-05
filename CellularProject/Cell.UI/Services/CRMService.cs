using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Cell.Models.Entities;
using Cell.UI.ServiceReference;

namespace Cell.UI.Services
{
    public class CRMService : ICRMService
    {
        private CellContractClient proxy;
        
        public CRMService()
        {
            proxy = new CellContractClient("NetTcpBinding_ICellContract");
        }

        public Task<Client> AddClient(Client client)
        {
            try
            {
                return proxy.AddClientAsync(client);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<Line> AddClientLine(Line line, string clientId)
        {
            try
            {
                return proxy.AddClientLineAsync(line, clientId);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<ClientType> AddClientType(ClientType clientType)
        {
            try
            {
                return proxy.AddClientTypeAsync(clientType);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<Package> AddPackage(Package package)
        {
            try
            {
                return proxy.AddPackageAsync(package);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<ObservableCollection<Client>> GetAllClients()
        {
            try
            {
                return proxy.GetAllClientsAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<ObservableCollection<Line>> GetAllLines()
        {
            try
            {
                return proxy.GetAllLinesAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<ObservableCollection<Package>> GetAllPackages()
        {
            try
            {
                return proxy.GetAllPackagesAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<ObservableCollection<ClientType>> GetClientTypes()
        {
            try
            {
                return proxy.GetClientTypesAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<Client> LoginClient(string id, string contactNumber)
        {
            try
            {
                return proxy.LoginClientAsync(id, contactNumber);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> LoginUser(string fullName, string password)
        {
            try
            {
                return proxy.LoginUserAsync(fullName, password);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> RemoveClient(string id)
        {
            try
            {
                return proxy.RemoveClientAsync(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> RemoveClientLine(string number)
        {
            try
            {
                return proxy.RemoveClientLineAsync(number);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> RemoveClientType(ClientType clientType)
        {
            try
            {
                return proxy.RemoveClientTypeAsync(clientType);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> UpdateClient(Client client)
        {
            try
            {
                return proxy.UpdateClientAsync(client);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> UpdateClientLine(Line line)
        {
            try
            {
                return proxy.UpdateClientLineAsync(line);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> UpdateClientType(ClientType clientType)
        {
            try
            {
                return proxy.UpdateClientTypeAsync(clientType);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Task<bool> UpdatePackage(Package package)
        {
            try
            {
                return proxy.UpdatePackageAsync(package);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }
        //todo:....
        public Task<byte[]> ExportInvoiceExcel(int lineId, int month, int year)
        {
            throw new NotImplementedException();
        }
        //todo:....
        public Task<byte[]> ExportInvoicePdf(int lineId, int month, int year)
        {
            throw new NotImplementedException();
        }
        //todo:....
        public Task<ObservableCollection<Invoice>> GetInvoices()
        {
            throw new NotImplementedException();
        }
        //todo:....
        public Task<Package> GetOptimalPackage(int lineId)
        {
            throw new NotImplementedException();
        }
    }
}
