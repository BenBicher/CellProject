using Cell.DAL;
using Cell.Models.Entities;
using Cell.Models.Interfaces.Managers;
using Cell.Models.Interfaces.Repositories;
using System.Collections.Generic;

namespace Cell.BL.Managers
{
    public class ClientTypeManager : IClientTypeManager
    {
        private IClientTypeRepository _clientTypeRepository;

        public ClientTypeManager()
        {
            _clientTypeRepository = new ClientTypeRepository();
        }

        public ClientTypeManager(IClientTypeRepository clientTypeRepository)
        {
            _clientTypeRepository = clientTypeRepository;
        }

        public ClientType AddClientType(ClientType clientType)
        {
            return _clientTypeRepository.AddClientType(clientType);
        }

        public IEnumerable<ClientType> GetClientTypes()
        {
            return _clientTypeRepository.GetAllClientTypes();
        }

        public bool RemoveClientType(ClientType clientType)
        {
            return _clientTypeRepository.RemoveClientType(clientType);
        }

        public bool UpdateClientType(ClientType clientType)
        {
            return _clientTypeRepository.UpdateClientType(clientType);
        }
    }
}