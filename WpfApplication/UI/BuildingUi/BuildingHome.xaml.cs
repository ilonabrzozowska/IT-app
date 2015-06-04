using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataLayer.Models;
using BusinessLayer;
using WpfApplication.UI.BuildingUi;
using WpfApplication.ModelViews.BuildingModelViews;
using Service = BusinessLayer.Service;


namespace WpfApplication.UI.BuildingUi
{
    /// <summary>
    /// Interaction logic for BuildingHome.xaml
    /// </summary>
    
    public partial class BuildingHome : UserControl
    {
        BuildingModelView modelView;
        private List<Building> _buildingList;
        private string con =
           @"Data Source=(LocalDb)\Projects;Initial Catalog=DataLayer.ThreeTier;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;";

        public BuildingHome()
        {
            InitializeComponent();
            try
            {
                modelView = new BuildingModelView();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            DataContext = modelView;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            modelView.ShowNewBuilding();
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            _buildingList = Service.GetAllBuildings();
            build.ItemsSource = Service.GetAllBuildings();
        }

        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var contextMenu = (ContextMenu)menuItem.Parent;
            var item = (DataGrid)contextMenu.PlacementTarget;
            var building = (Building)item.SelectedCells[0].Item;
            modelView.DeleteBuilding(building);
        }
    }
}
