using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;
using DataLayer.Models;
using WpfApplication.ModelViews.ClientModelViews;

namespace WpfApplication.UI.ClientUI
{
    /// <summary>
    /// Interaction logic for HomeHome.xaml
    /// </summary>
    public partial class ClientHome : UserControl
    {

        ClientModelView modelView;
        private List<Client> _clientList;


        public ClientHome()
        {
            InitializeComponent();
            try
            {
                modelView = new ClientModelView();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            DataContext = modelView;
        }

        private void buttonDownload_Click(object sender, RoutedEventArgs e)
        {
            _clientList = Service.GetAllClients();
            client.ItemsSource = Service.GetAllClients();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            modelView.ShowNewClient();

        }
        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var contextMenu = (ContextMenu)menuItem.Parent;
            var item = (DataGrid)contextMenu.PlacementTarget;
            var client = (Client)item.SelectedCells[0].Item;
            modelView.DeleteClient(client);
        }

        
    }
}
