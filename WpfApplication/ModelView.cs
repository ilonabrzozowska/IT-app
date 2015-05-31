using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BusinessLayer;
using DataLayer.Models;
using WpfApplication.UI.BuildingUi;

namespace WpfApplication
{
    public class ModelView : INotifyPropertyChanged
    {
    //    private BindingList<Building> _buildingList;
        private List<Building> _buildingList; 

        //public BindingList<Building> BuildingList
        //{
        //    get { return _buildingList; }
        //    set { _buildingList = value; OnPropertyChanged("BuildingList"); }
        //}
        public List<Building> BuildingList
        {
            get { return _buildingList; }
            set { _buildingList = value; OnPropertyChanged("BuildingList"); }
        }

        public void GetBuildingList()
        {
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

        public ModelView()
        {
            Service.GetAllBuildings();
        }

        
        public void GetList()
        {
        }

       

    }
}
