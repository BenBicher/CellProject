using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Repositories
{
    public interface IClientTypeRepository
    {
        IEnumerable<ClientType> GetAllClientTypes();
        ClientType AddClientType(ClientType clientType);
        bool UpdateClientType(ClientType clientType);
        bool RemoveClientType(ClientType clientType);
    }
}