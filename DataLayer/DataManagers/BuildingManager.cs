using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.DataManagers
{
    public class BuildingManager : DataManager<Building>
    {
        public override Building Add(Building obj)
        {           
            Db.Table.Buildings.Add(obj);
            Submit();
            return obj;
        }

        public override bool Delete(Building obj)
        {
            Db.Table.Buildings.Remove(obj);
            if (Submit())
                return true;
            return false;
        }

        public override bool Delete(int id)
        {
            Db.Table.Buildings.Remove(GetById(id));
            if (Submit())
                return true;
            return false;
        }

        public override Building GetById(int id)
        {
            return (from c in Db.Table.Buildings
                    where c.BuildingId == id
                    select c).FirstOrDefault();
        }


        public override List<Building> GetList()
        {
            return Db.Table.Buildings.ToList();
        }
    }
}
