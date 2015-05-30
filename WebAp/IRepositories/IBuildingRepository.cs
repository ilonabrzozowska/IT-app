using System.Collections.Generic;
using DataLayer.Models;

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