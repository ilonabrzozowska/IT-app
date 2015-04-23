using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.IRepositories;
using WebAp.Models;


namespace WebAp.Repositories
{
    public class BillRepository : Repository<Bill>, IBillRepository
    {
        public BillRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Bill>();
        }
    }
}