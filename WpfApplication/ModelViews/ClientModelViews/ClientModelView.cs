using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer.Models;
using WpfApplication.UI.ClientUI;

namespace WpfApplication.ModelViews.ClientModelViews
{
    public class ClientModelView : INotifyPropertyChanged
    {

        private List<Client> _clientList;
        private Client _newClient;
        

        public List<Client> ClientList
        {
            get { return _clientList; }
            set { _clientList = value; OnPropertyChanged("ClientList"); }
        }

        public ClientModelView()
        {
            NewClient = new Client();
            ClientList = Service.GetAllClients();
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

        public void GetClientList()
        {
            ClientList = Service.GetAllClients();
        }

        public Client NewClient
        {
            get { return _newClient; }
            set { _newClient = value; OnPropertyChanged("NewClient"); }
        }

        public void ShowNewClient()
        {
            EditClient newClient = new EditClient(this);
            newClient.ShowDialog();
        }

        public void ResetEditValue()
        {
            NewClient = new Client();
        }


        public void AddNewClient()
        {
            NewClient = Service.AddClient(NewClient);
            if (NewClient.ClientId != null)
            {
                _clientList.Add(NewClient);
            }
        }


        public void DeleteClient(Client Client)
        {
            Service.DeleteClient(Client);
        }
    }
}
