using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.IRepositories;
using WebAp.Models;


namespace WebAp.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Item>();
        }
    }
}