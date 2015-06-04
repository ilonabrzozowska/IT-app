using System;
using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using BusinessLayer;
using DataLayer.Models;
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
        private Bill _newBill;


        public EditBill(BillsModelView modelView)
        {
            InitializeComponent();
            this.modelView = modelView;
            DataContext = this.modelView;
            modelView.ResetEditValue();
            ComboBoxItem.ItemsSource = Service.GetAllItems();
            
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem.SelectedIndex = modelView.NewBill.ItemId;
         //   cos.ItemId = bill.SelectedIndex;
            //SqlConnection sqlcon = new SqlConnection(con);
            //var menuItem = (MenuItem)sender;
            //var contextMenu = (ContextMenu)menuItem.Parent;
            //var item = (DataGrid)contextMenu.PlacementTarget;
            //var client = (Client)item.SelectedCells[0].Item;
     //       modelView.DeleteClient(client);
            //try
            //{
            //    sqlcon.Open();
            //    string query = "insert into Bills (ClientId, DateIssue, Quantity, ItemId, PayDate )" +
            //                   " values('" + Int32.Parse(textBoxClientId.Text) + "', '" + DateTime.Parse(textBoxDateIssue.Text) + "', '" + float.Parse(textBoxQuantity.Text) + "', '" + Int32.Parse(textBoxItem.Text) + "', '" + DateTime.Parse(textBoxPayDate.Text) + "')";
            //    SqlCommand createCommand = new SqlCommand(query, sqlcon);
            //    createCommand.ExecuteNonQuery();
            //    MessageBox.Show("Saved");
            //    sqlcon.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            modelView.NewBill.ItemId = ComboBoxItem.SelectedIndex;
            modelView.AddNewBill();
            this.Close();
        }
    }
}
