using System.Collections.Generic;
using DataLayer.Models;
using WebAp.IRepositories;
using System.Linq;

namespace WebAp.Repositories
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(ThreeTierContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Building>();
        }

        public List<Building> GetAllBuildings1()
        {
            var query = from build in context.Buildings select build;
            return query.ToList();
        }

        public IEnumerable<Building> GetAllBuildings()
        {
            var query = from build in context.Buildings select build;
            return query.ToList();
        }
    }
}