using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DataManagers;
using DataLayer.Models;


namespace BusinessLayer
{
    public class Service
    {
        public static List<Client> GetAllClients()
        {
            return Provider.GetAllClients();
        }

        public static Client AddClient(Client newClient)
        {
            return Provider.AddClient(newClient);
        }

        public static bool DeleteClient(Client client)
        {
            return Provider.DeleteClient(client);
        }

        public static List<Building> GetAllBuildings()
        {
            return Provider.GetAllBuildings();
        }   

        public static Building AddBuilding(Building newBuilding)
        {
            return Provider.AddBuilding(newBuilding);
        }

        public static bool DeleteBuilding(Building building)
        {
            return Provider.DeleteBuilding(building);
        }

        public static List<Bill> GetAllBills()
        {
            return Provider.GetAllBills();
        }

        public static List<Item> GetAllItems()
        {
            return Provider.GetAllItems();
        }

        public static Bill AddBill(Bill newBill)
        {
            return Provider.AddBill(newBill);
        }

        public static bool DeleteBill(Bill bill)
        {
            return Provider.DeleteBill(bill);
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
