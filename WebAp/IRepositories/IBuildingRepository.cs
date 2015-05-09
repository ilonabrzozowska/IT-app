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
      //  List<Building> GetBuildings();
        List<Building> GetAllBuildings1();
        //IEnumerable<Building> GetAll();

        
    }
}