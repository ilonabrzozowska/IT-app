using DataLayer.Models;
using WebAp.IRepositories;


namespace WebAp.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ThreeTierContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Item>();
        }
    }
}