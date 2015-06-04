using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataManagers;
using DataLayer.Models;



namespace DataLayer
{
    public class Provider
    {        
        public static List<Client> GetAllClients()
        {
            List<Client> lst = null;
            lst = (from u in Db.Table.Clients select u).ToList();
            return lst;
        }

        public static Client AddClient(Client newClient)
        {
            Db.Table.Clients.Add(newClient);
            Db.Table.SaveChanges();
            Submit();
            return newClient;
        }

        public static bool DeleteClient(Client client)
        {
            Db.Table.Clients.Remove(client);
            if (Submit())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static List<Building> GetAllBuildings()
        {
            List<Building> lst = null;
            lst = (from a in Db.Table.Buildings select a).ToList();
            return lst;
        }


        public static Building AddBuilding(Building newBuilding)
        {
            Db.Table.Buildings.Add(newBuilding);
            Db.Table.SaveChanges();
            Submit();
            return newBuilding;
        }

        public static bool DeleteBuilding(Building building)
        {
            Db.Table.Buildings.Remove(building);
            if (Submit())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<Bill> GetAllBills()
        {
            List<Bill> lst = null;
            lst = (from a in Db.Table.Bills select a).ToList();
            return lst;
        }

        public static List<Item> GetAllItems()
        {
            List<Item> lst = null;
            lst = (from a in Db.Table.Items select a).ToList();
            return lst;
        } 

        public static Bill AddBill(Bill newBill)
        {
            
            Db.Table.Bills.Add(newBill);
            Db.Table.SaveChanges();
            Submit();
            return newBill;
        }

        public static bool DeleteBill(Bill bill)
        {
            Db.Table.Bills.Remove(bill);
            if (Submit())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Submit()
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
       
        #region PropertyNotification
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
