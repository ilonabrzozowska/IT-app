using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;
using WebAp.IRepositories;
using WebAp.Repositories;
using WebAp.Controllers;
using WebAp.ModelsView;
using System.Data.Entity;


namespace WebAp.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Client>();
        }

        public IEnumerable<Client> GetAllClients()
        {
            var query = from cli in context.Clients select cli;
            return query.ToList();
        }

        public Client GetClientById(int clientId)
        {
            var query = from usr in context.Clients where usr.ClientID == clientId select usr;
            return query.FirstOrDefault();
        }


        public HomePage GetHomePageByClient(int clientId)
        {
            RepositoryFactory factory = new RepositoryFactory(context);
            HomePage home = new HomePage();
            home.Client = factory.Create<IClientRepository>().GetByID(clientId);
            home.Buildings = factory.Create<IBuildingRepository>().GetAll();
            return home;
        }



        public BuildingPage GetBuildingPageByClient(Client clientId)
        {
            RepositoryFactory factory = new RepositoryFactory(context);
            BuildingPage build = new BuildingPage();
        //    build.Client = factory.Create<IClientRepository>().GetByID(clientId);
            build.Buildings = factory.Create<IBuildingRepository>().GetAll();
            build.Clients = factory.Create<IClientRepository>().GetAllClients();
            build.Client = clientId;
            return build;
        }

        public BillPage GetBillPageByClient(Client clientId)
        {
            RepositoryFactory factory = new RepositoryFactory(context);
            BillPage bill = new BillPage();
            bill.Buildings = factory.Create<IBuildingRepository>().GetAll();
            bill.Clients = factory.Create<IClientRepository>().GetAllClients();
            bill.Client = clientId;
            return bill;
        }

    }
}