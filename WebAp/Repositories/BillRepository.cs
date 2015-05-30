using DataLayer.Models;
using WebAp.IRepositories;


namespace WebAp.Repositories
{
    public class BillRepository : Repository<Bill>, IBillRepository
    {
        public BillRepository(ThreeTierContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Bill>();
        }
    }
}