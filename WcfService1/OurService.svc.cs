using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Service.Models;
using Service.DataManagers;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public partial class OurService : IOurService
    {
        private BuildingManager buildingManager = new BuildingManager();
        static OurService() { }

        public string Hello()
        {
            return "Hello World";
        }

        public List<Building> GetBuildings()
        {
            return buildingManager.GetList();
        }

        public Building GetBuildingByID(int id)
        {
            return buildingManager.GetById(id);
        }

        public Building AddBuilding(Building building)
        {
            return buildingManager.Add(building);
        }

        public bool DeleteBuilding(Building building)
        {
            return buildingManager.Delete(building.BuildingID);
        }
    }
}
