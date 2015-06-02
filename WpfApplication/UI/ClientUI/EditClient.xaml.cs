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
using WpfApplication.ModelViews.ClientModelViews;

namespace WpfApplication.UI.ClientUI
{
    /// <summary>
    /// Interaction logic for EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        private string con =
            @"Data Source=(LocalDb)\Projects;Initial Catalog=DataLayer.ThreeTier;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;";

        ClientModelView modelView;

        public EditClient(ClientModelView modelView)
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
            //SqlConnection sqlcon = new SqlConnection(con);
            //try
            //{
            //    sqlcon.Open();
            //    string query = "insert into Clients (Name, Surname, Email, FlatNumber, BuildingId, Phone )" +
            //                   " values('" + textBoxName.Text + "', '" + textBoxSurname.Text + "', '" + textBoxEmail.Text + "', '" + textBoxFlatNumber.Text + "', '" + Int32.Parse(textBoxBuildingId.Text) + "', '" + textBoxPhone.Text + "')";
            //    SqlCommand createCommand = new SqlCommand(query, sqlcon);
            //    createCommand.ExecuteNonQuery();
            //    MessageBox.Show("Saved");
            //    sqlcon.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            modelView.AddNewClient();           
            this.Close();
        }
    }
}
