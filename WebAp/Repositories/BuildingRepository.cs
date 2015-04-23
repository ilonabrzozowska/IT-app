using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;
using WebAp.IRepositories;

namespace WebAp.Repositories
{
    public class BuildingRepository : Repository<Building>, IBuildingRepository
    {
        public BuildingRepository(WebApContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Building>();
        }

        public IEnumerable<Building> GetAllBuildings()
        {
            var query = from build in context.Buildings select build;
            return query.ToList();
        }
    }
}