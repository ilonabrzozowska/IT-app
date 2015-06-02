using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using WpfApplication.UI.BuildingUi;



namespace WpfApplication.ModelViews.BuildingModelViews
{
    public class BuildingModelView : INotifyPropertyChanged
    {

        private List<Building> _buildingList;
        private Building _newBuilding;
        private string con =
            @"Data Source=(LocalDb)\Projects;Initial Catalog=DataLayer.ThreeTier;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;";

       // Service service = new Service();


        public List<Building> BuildingList
        {
            get { return _buildingList; }
            set { _buildingList = value; OnPropertyChanged("BuildingList"); }
        }

        public BuildingModelView()
        {
            NewBuilding = new Building();
            BuildingList =  Service.GetAllBuildings();
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

        public void GetBuildingList()
        {
            BuildingList = Service.GetAllBuildings();
        }

        public Building NewBuilding
        {
            get { return _newBuilding; }
            set { _newBuilding = value; OnPropertyChanged("NewBuilding"); }
        }

        public void ShowNewBuilding()
        {
            EditBuilding newBuilding = new EditBuilding(this);
            newBuilding.ShowDialog();
        }

        public void ResetEditValue()
        {
            NewBuilding = new Building();
        }


        public void AddNewBuilding()
        {
            NewBuilding = Service.AddBuilding(NewBuilding);
            if (NewBuilding.BuildingId != null)
            {
                _buildingList.Add(NewBuilding);
            }
        }


        public void DeleteBuilding(Building building)
        {
            Service.DeleteBuilding(building);
        }
    }
}
