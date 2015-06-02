using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication.ModelViews.BuildingModelViews;

namespace WpfApplication.UI.BuildingUi
{
    /// <summary>
    /// Interaction logic for EditBuilding.xaml
    /// </summary>
    public partial class EditBuilding : Window
    {
        private string con =
            @"Data Source=(LocalDb)\Projects;Initial Catalog=DataLayer.ThreeTier;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;";

        BuildingModelView modelView;

        public EditBuilding(BuildingModelView modelView)
        {
            InitializeComponent();
            this.modelView = modelView;
            DataContext = this.modelView;
            modelView.ResetEditValue();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(con);
            try
            {
                sqlcon.Open();
                string query = "insert into Buildings (District, Street, City, PostCode, FlatCount, BuildingNumber)" +
                               " values('" + textBoxDistrict.Text + "', '" + textBoxStreet.Text + "', '" + textBox.Text + "', '" + textBoxPostCode.Text + "', '" + textBoxFlatCount.Text + "', '" + textBoxBuildingNumber.Text + "')";
                SqlCommand createCommand = new SqlCommand(query, sqlcon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Saved");
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          //  modelView.AddNewBuilding();           
            this.Close();
        }
    }
}
