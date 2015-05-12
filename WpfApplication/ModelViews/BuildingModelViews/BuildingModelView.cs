using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WpfApplication.UI.BuildingUi;
using Service;
using Service.Models;


namespace WpfApplication.ModelViews.BuildingModelViews
{
    public class BuildingModelView : INotifyPropertyChanged
    {
        private OurService server = WcfService.Instance;
       
        private List<Building> buildingList;

        //private BindingList<Building> buildingList;
        private Building selectedBuilding;
        private Building newBuilding;
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

        public Building NewBuilding
        {
            get { return newBuilding; }
            set { newBuilding = value; OnPropertyChanged("NewBuilding"); }
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

        public BuildingModelView()
        {
            NewBuilding = new Building();
            buildingList = server.GetBuildings();

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

        public void ShowNewBuilding()
        {
            EditBuilding newBuilding = new EditBuilding(this);
            newBuilding.ShowDialog();
        }



        public void AddNewBuilding()
        {
            NewBuilding = server.AddBuilding(NewBuilding);
            if (NewBuilding.BuildingID != null)
            {
                buildingList.Add(NewBuilding);
            }
        }

        public void DeleteBuilding(Building building)
        {
            server.DeleteBuilding(building);
        }

        public void ResetEditValue()
        {
            NewBuilding = new Building();
        }
    }
}
