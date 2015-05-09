using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Service.Models;

namespace Service
{
    [ServiceContract]
    public interface IOurService
    {
        [OperationContract]
        string Hello();

        [OperationContract]
        List<Building> GetBuildings();

        [OperationContract]
        Building GetBuildingByID(int id);

        [OperationContract]
        Building AddBuilding(Building building);

        [OperationContract]
        bool DeleteBuilding(Building building);
    }

}
