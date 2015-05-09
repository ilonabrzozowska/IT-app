using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.DataManagers
{
    public abstract class DataManager<T> where T : class
    {
        public abstract T Add(T obj);
        public abstract bool Delete(T obj);
        public abstract bool Delete(int id);
        public abstract T GetById(int id);
        public abstract List<T> GetList();

        public bool Submit()
        {
            try
            {      
                
                Db.Table.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}