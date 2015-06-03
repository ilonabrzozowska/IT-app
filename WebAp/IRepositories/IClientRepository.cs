using System.Collections.Generic;
using DataLayer.Models;
using WebAp.ModelsView;

namespace WebAp.IRepositories
{
    interface IClientRepository : IRepository<Client>
    {
        Client GetClientById(int clientId);
        HomePage GetHomePageByClient(int clientId);
        IEnumerable<Client> GetAllClients();
        BuildingPage GetBuildingPageByClient(Client clientId);
        BillPage GetBillPageByClient(Client clientId);
        MessagePage GetMessagePageByClient(Client cliendId);

    }
}