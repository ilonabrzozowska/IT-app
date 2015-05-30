using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class Provider
    {
        public static List<Client> GetAllUsers()
        {
            List<Client> lst = null;
            lst = (from u in Db.Table.Clients select u).ToList();
            return lst;
        }
    }
}
