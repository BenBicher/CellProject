using Cell.BL.Services;
using Cell.DAL;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Managers;
using Cell.Models.Interfaces.Repositories;
using System.Collections.Generic;

namespace Cell.BL.Managers
{
    public class ClientManager : IClientManager
    {
        private IClientRepository _clientRepository;

        public ClientManager()
        {
            _clientRepository = new ClientRepository();
        }

        public ClientManager(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client AddClient(Client client)
        {
            return _clientRepository.AddClient(client);
        }

        public IEnumerable<Line> GetAllLines()
        {
            return _clientRepository.GetAllLines();
        }

        public Line AddClientLine(Line line, string clientId)
        {
            return _clientRepository.AddClientLine(line, clientId);
        }

        public byte[] ExportInvoiceExcel(int lineId, int month, int year)
        {
            // todo : add a way to get an invoice, from db, or calculate on the fly.
            Invoice invoice = new Invoice();
            return new ExcelExporter().ExportInvoice(invoice);
        }

        public byte[] ExportInvoicePdf(int lineId, int month, int year)
        {
            // todo : add a way to get an invoice, from db, or calculate on the fly.
            Invoice invoice = new Invoice();
            return new PdfExporter().ExportInvoice(invoice);

        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAllClients();
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            // todo : add a way to get an invoice, from db, or calculate on the fly.
            return new List<Invoice>();
        }

        public Client LoginClient(string Id, string contactNumber)
        {
            return _clientRepository.LoginClient(Id, contactNumber);
        }

        public bool RemoveClient(string id)
        {
            return _clientRepository.RemoveClient(id);
        }

        public bool RemoveClientLine(string number)
        {
            return _clientRepository.RemoveClientLine(number);
        }

        public bool UpdateClient(Client client)
        {
            return _clientRepository.UpdateClient(client);
        }

        public bool UpdateClientLine(Line line)
        {
            return _clientRepository.UpdateClientLine(line);
        }
    }
}