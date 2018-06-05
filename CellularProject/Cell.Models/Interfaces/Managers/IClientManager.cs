using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Managers
{
    public interface IClientManager
    {
        Client LoginClient(string Id, string contactNumber);
        IEnumerable<Client> GetAllClients();
        IEnumerable<Line> GetAllLines();
        //Client GetClient();
        
        IEnumerable<Invoice> GetInvoices();
        byte[] ExportInvoicePdf(int lineId, int month, int year);
        byte[] ExportInvoiceExcel(int lineId, int month, int year);

        Client AddClient(Client client);
        bool UpdateClient(Client client);
        bool RemoveClient(string id);

        Line AddClientLine(Line line, string clientId);
        bool UpdateClientLine(Line line);
        bool RemoveClientLine(string number);
    }
}