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

      //  private OurService server;
      

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


        }

        /// <summary>
        /// Pobranie listy studentów
        /// </summary>
        public void GetList()
        {
            //StudentList = server.GetStudents(); // Dane zostaną automatycznie zmienione w widoku dzięki bindowaniu
        }

       

    }
}
