using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Controllers;
using WebAp.IRepositories;
using WebAp.Models;
using WebAp.ModelsView;
using WebAp.Repositories;

namespace WebAp.IRepositories
{
    interface IClientRepository : IRepository<Client>
    {
        Client GetClientById(int clientId);
        HomePage GetHomePageByClient(int clientId);
        IEnumerable<Client> GetAllClients();
        BuildingPage GetBuildingPageByClient(Client clientId);
        BillPage GetBillPageByClient(Client clientId);

    }
}