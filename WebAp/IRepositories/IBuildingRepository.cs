using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAp.Models;

namespace WebAp.IRepositories
{
    interface IBuildingRepository : IRepository<Building>
    {
        IEnumerable<Building> GetAllBuildings();

        //IEnumerable<Building> GetAll();

        
    }
}