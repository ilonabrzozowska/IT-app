using System.Collections.Generic;
using WebAp.IRepositories;
using WebAp.ModelsView;
using DataLayer.Models;
using System.Linq;


namespace WebAp.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(ThreeTierContext context)
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
            var query = from usr in context.Clients where usr.ClientId == clientId select usr;
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
            build.Messages = factory.Create<IMessageRepository>().GetAll();
            return build;
        }

        public BillPage GetBillPageByClient(Client clientId)
        {
            RepositoryFactory factory = new RepositoryFactory(context);
            BillPage bill = new BillPage();
            bill.Buildings = factory.Create<IBuildingRepository>().GetAll();
            bill.Clients = factory.Create<IClientRepository>().GetAllClients();
            bill.Client = clientId;
            bill.Bills = factory.Create<IBillRepository>().GetAll();
            bill.Items = factory.Create<IItemRepository>().GetAll();
            return bill;
        }

        public MessagePage GetMessagePageByClient(Client clientId)
        {
            RepositoryFactory factory = new RepositoryFactory(context);
            MessagePage message = new MessagePage();
            message.Buildings = factory.Create<IBuildingRepository>().GetAll();
            message.Clients = factory.Create<IClientRepository>().GetAllClients();
            message.Client = clientId;
            message.Bills = factory.Create<IBillRepository>().GetAll();
            message.Items = factory.Create<IItemRepository>().GetAll();
            message.Messages = factory.Create<IMessageRepository>().GetAllMessages();
            return message;
        }
    }
}