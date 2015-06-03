using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.DataManagers
{
    public class ClientManager : DataManager<Client>
    {
        public override Client Add(Client obj)
        {
            Db.Table.Clients.Add(obj);
            Submit();
            return obj;
        }

        public override bool Delete(Client obj)
        {
            Db.Table.Clients.Remove(obj);
            if (Submit())
                return true;
            return false;
        }

        public override bool Delete(int id)
        {
            Db.Table.Clients.Remove(GetById(id));
            if (Submit())
                return true;
            return false;
        }

        public override Client GetById(int id)
        {
            return (from c in Db.Table.Clients
                    where c.ClientId == id
                    select c).FirstOrDefault();
        }


        public override List<Client> GetList()
        {
            return Db.Table.Clients.ToList();
        }
    }
}
