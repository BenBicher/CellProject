using Cell.Models.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Cell.UI.Services
{
    public interface ICRMService
    {
        // Client services
        Task<Client> LoginClient(string Id, string contactNumber);
        Task<ObservableCollection<Client>> GetAllClients();
        Task<ObservableCollection<Line>> GetAllLines();
        Task<ObservableCollection<Invoice>> GetInvoices();
        Task<byte[]> ExportInvoicePdf(int lineId, int month, int year);
        Task<byte[]> ExportInvoiceExcel(int lineId, int month, int year);
        Task<Client> AddClient(Client client);
        Task<bool> UpdateClient(Client client);
        Task<bool> RemoveClient(string id);
        // Client line services
        Task<Line> AddClientLine(Line line, string clientId);
        Task<bool> UpdateClientLine(Line line);
        Task<bool> RemoveClientLine(string number);
        // client type services
        Task<ObservableCollection<ClientType>> GetClientTypes();
        Task<ClientType> AddClientType(ClientType clientType);
        Task<bool> UpdateClientType(ClientType clientType);
        Task<bool> RemoveClientType(ClientType clientType);
        // package services
        Task<ObservableCollection<Package>> GetAllPackages();
        Task<Package> GetOptimalPackage(int lineId);
        Task<Package> AddPackage(Package package);
        Task<bool> UpdatePackage(Package package);
        Task<bool> LoginUser(string fullName, string password);
    }
}