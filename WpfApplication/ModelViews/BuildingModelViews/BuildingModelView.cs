using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using WpfApplication.UI.BuildingUi;



namespace WpfApplication.ModelViews.BuildingModelViews
{
    public class BuildingModelView : INotifyPropertyChanged
    {
       
        

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

       

        /// <summary>
        /// Pobranie listy studentów
        /// </summary>
        public void GetList()
        {
            //StudentList = server.GetStudents(); // Dane zostaną automatycznie zmienione w widoku dzięki bindowaniu
        }


    }
}
