using Cell.BL.Managers;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Managers;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Cell.Service
{
    public class CellService : ICellContract
    {
        private IClientManager _clientManager;
        private IUserManager _userManager;
        private IClientTypeManager _typeManager;
        private IPackageManager _packageManager;

        public CellService()
        {
            _userManager = new UserManager();
            _typeManager = new ClientTypeManager();
            _clientManager = new ClientManager();
            _packageManager = new PackageManager();
        }

        public CellService(IClientManager clientManager, IUserManager userManager, IClientTypeManager typeManager, IPackageManager packageManager)
        {
            _clientManager = clientManager;
            _userManager = userManager;
            _typeManager = typeManager;
            _packageManager = packageManager;
        }

        public Client AddClient(Client client)
        {
            return _clientManager.AddClient(client);
        }

        public Line AddClientLine(Line line, string clientId)
        {
            return _clientManager.AddClientLine(line, clientId);
        }

        public ClientType AddClientType(ClientType clientType)
        {
            return _typeManager.AddClientType(clientType);
        }

        public Package AddPackage(Package package)
        {
            return _packageManager.AddPackage(package);
        }

        //todo:....
        public byte[] ExportInvoiceExcel(int lineId, int month, int year)
        {
            throw new NotImplementedException();
        }
        //todo:......
        public byte[] ExportInvoicePdf(int lineId, int month, int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientManager.GetAllClients();
        }

        public IEnumerable<Line> GetAllLines()
        {
            return _clientManager.GetAllLines();
        }

        public IEnumerable<Package> GetAllPackages()
        {
            return _packageManager.GetAllPackages();
        }

        public IEnumerable<ClientType> GetClientTypes()
        {
            return _typeManager.GetClientTypes();
        }
        // todo:....
        public IEnumerable<Invoice> GetInvoices()
        {
            throw new NotImplementedException();
        }

        public Package GetOptimalPackage(int lineId)
        {
            return _packageManager.GetOptimalPackage(lineId);
        }

        public Client LoginClient(string Id, string contactNumber)
        {
            return _clientManager.LoginClient(Id, contactNumber);
        }

        public bool LoginUser(string fullName, string password)
        {
            return _userManager.LoginUser(fullName, password);
        }

        public bool RemoveClient(string id)
        {
            return _clientManager.RemoveClient(id);
        }

        public bool RemoveClientLine(string number)
        {
            return _clientManager.RemoveClientLine(number);
        }

        public bool RemoveClientType(ClientType clientType)
        {
            return _typeManager.RemoveClientType(clientType);
        }

        public bool UpdateClient(Client client)
        {
            return _clientManager.UpdateClient(client);
        }

        public bool UpdateClientLine(Line line)
        {
            return _clientManager.UpdateClientLine(line);
        }

        public bool UpdateClientType(ClientType clientType)
        {
            return _typeManager.UpdateClientType(clientType);
        }

        public bool UpdatePackage(Package package)
        {
            return _packageManager.UpdatePackage(package);
        }
    }
}