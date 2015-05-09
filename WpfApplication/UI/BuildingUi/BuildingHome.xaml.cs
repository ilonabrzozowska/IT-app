using System;
using System.Collections.Generic;
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
using WpfApplication.UI.BuildingUi;
using WpfApplication.ModelViews.BuildingModelViews;

namespace WpfApplication.UI.BuildingUi
{
    /// <summary>
    /// Interaction logic for BuildingHome.xaml
    /// </summary>
    
    public partial class BuildingHome : UserControl
    {
        BuildingModelView modelView;

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
            modelView.AddNewBuilding();
          //  modelView.ShowNewBuilding();
        }

        private void Download_Click(object sender, RoutedEventArgs e)
        {
            modelView.GetBuildingList();
        }


    }
}
