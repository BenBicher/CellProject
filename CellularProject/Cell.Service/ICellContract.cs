using Cell.Models.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Cell.Service
{
    [ServiceContract]
    public interface ICellContract
    {
        // Client services
        [OperationContract]
        Client LoginClient(string Id, string contactNumber);
        [OperationContract]
        IEnumerable<Client> GetAllClients();
        [OperationContract]
        IEnumerable<Line> GetAllLines();
        [OperationContract]
        IEnumerable<Invoice> GetInvoices();
        [OperationContract]
        byte[] ExportInvoicePdf(int lineId, int month, int year);
        [OperationContract]
        byte[] ExportInvoiceExcel(int lineId, int month, int year);
        [OperationContract]
        Client AddClient(Client client);
        [OperationContract]
        bool UpdateClient(Client client);
        [OperationContract]
        bool RemoveClient(string id);
        // Client line services
        [OperationContract]
        Line AddClientLine(Line line, string clientId);
        [OperationContract]
        bool UpdateClientLine(Line line);
        [OperationContract]
        bool RemoveClientLine(string number);
        // client type services
        [OperationContract]
        IEnumerable<ClientType> GetClientTypes();
        [OperationContract]
        ClientType AddClientType(ClientType clientType);
        [OperationContract]
        bool UpdateClientType(ClientType clientType);
        [OperationContract]
        bool RemoveClientType(ClientType clientType);
        // package services
        [OperationContract]
        IEnumerable<Package> GetAllPackages();
        [OperationContract]
        Package GetOptimalPackage(int lineId);
        [OperationContract]
        Package AddPackage(Package package);
        [OperationContract]
        bool UpdatePackage(Package package);
        // user/representative login
        [OperationContract]
        bool LoginUser(string fullName, string password);
    }
}
