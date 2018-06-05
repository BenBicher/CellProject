using Cell.Models.Entities;
using Cell.Models.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMUnitTest.Mocks
{
    class ClientRepositoryMock : IClientRepository
    {
        public Client AddClient(Client client)
        {
            return new Client
            {
                ClientId = "333",
                FirstName = "Ben",
                LastName = "Bicher",
                ClientType = new ClientType { TypeName = "High Society!" }
            };
        }

        public Client AddClientLine(Line line, string clientId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Line> GetAllLines()
        {
            throw new NotImplementedException();
        }

        public Line GetLine(int lineId)
        {
            throw new NotImplementedException();
        }

        public Client LoginClient(string id, string contactNumber)
        {
            throw new NotImplementedException();
        }

        public bool RemoveClient(string id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveClientLine(string number)
        {
            throw new NotImplementedException();
        }

        public bool UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public bool UpdateClientLine(Line line)
        {
            throw new NotImplementedException();
        }

        Line IClientRepository.AddClientLine(Line line, string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
