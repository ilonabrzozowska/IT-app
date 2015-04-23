using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;
using WebAp.IRepositories;


namespace WebAp.Repositories
{
    public class ItemDateRepository : Repository<ItemDate>, IItemDateRepository
    {
        public ItemDateRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<ItemDate>();
        }
    }
}