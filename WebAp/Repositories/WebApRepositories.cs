using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.IRepositories;


namespace WebAp.Repositories
{
    public class WebApRepositories
    {
        public RepositoryComponentInfo[] Repositories
        {
            get
            {
                return new[]
                           {
                                new RepositoryComponentInfo("Building", typeof(IBuildingRepository), typeof(BuildingRepository)),
                                new RepositoryComponentInfo("Client", typeof(IClientRepository), typeof(ClientRepository)),
                                new RepositoryComponentInfo("Bill", typeof(IBillRepository), typeof(BillRepository)),
                                new RepositoryComponentInfo("Position", typeof(IPositionRepository), typeof(PositionRepository)),
                                new RepositoryComponentInfo("Item", typeof(IItemRepository), typeof(ItemRepository)),
                                new RepositoryComponentInfo("ItemDate", typeof(IItemDateRepository), typeof(ItemDateRepository)),
                           };
            }
        }
    }
}