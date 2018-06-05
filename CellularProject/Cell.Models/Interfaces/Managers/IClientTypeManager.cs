using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Managers
{
    public interface IClientTypeManager
    {
        IEnumerable<ClientType> GetClientTypes();
        ClientType AddClientType(ClientType clientType);
        bool UpdateClientType(ClientType clientType);
        bool RemoveClientType(ClientType clientType);
    }
}
