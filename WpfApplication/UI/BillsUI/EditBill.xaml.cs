using System;
using System.Collections.Generic;
using System.Linq;

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
using System.Windows.Shapes;
using WpfApplication.ModelViews.BillsModelViews;

namespace WpfApplication.UI.BillsUI
{
    /// <summary>
    /// Interaction logic for EditBill.xaml
    /// </summary>
    public partial class EditBill : Window
    {
        private string con =
            @"Data Source=(LocalDb)\Projects;Initial Catalog=DataLayer.ThreeTier;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework;";

        BillsModelView modelView;

        public EditBill(BillsModelView modelView)
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
            modelView.AddNewBill();
            this.Close();
        }
    }
}
