using Cell.Models.Entities;
using System.Collections.Generic;

namespace Cell.Models.Interfaces.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Line> GetAllLines();
        IEnumerable<Client> GetAllClients();

        Client AddClient(Client client);
        bool UpdateClient(Client client);
        bool RemoveClient(string id);


        Line AddClientLine(Line line, string clientId);
        bool UpdateClientLine(Line line);
        bool RemoveClientLine(string number);

        Client LoginClient(string id, string contactNumber);
        Line GetLine(int lineId);
    }
}