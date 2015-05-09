using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Service;
using Service.Models;

namespace WpfApplication
{
    public class ModelView : INotifyPropertyChanged
    {
        private OurService server;

      //  private OurService server;
        private List<Building> buildingList;

        //private BindingList<Building> buildingList;
        private Building selectedBuilding;

        public List<Building> BuildingList

        //public BindingList<Building> BuildingList
        {
            get { return buildingList; }
            set { buildingList = value; OnPropertyChanged("BuildingList"); }
        }

        public Building SelectedBuilding
        {
            get { return selectedBuilding; }
            set { selectedBuilding = value; OnPropertyChanged("SelectedBuilding"); }
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

        public ModelView()
        {
            server = new OurService();
            BuildingList = server.GetBuildings();

        }

        /// <summary>
        /// Pobranie listy studentów
        /// </summary>
        public void GetList()
        {
            //StudentList = server.GetStudents(); // Dane zostaną automatycznie zmienione w widoku dzięki bindowaniu
        }

        public void GetBuildingList()
        {
            BuildingList = server.GetBuildings();
        }



    }
}
