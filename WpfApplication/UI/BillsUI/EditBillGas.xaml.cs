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
    public partial class EditBillGas : Window
    {
        BillsModelView modelView;
        private Bill _newBill;


        public EditBillGas(BillsModelView modelView)
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
            modelView.NewBill.ItemId = 2;
            modelView.AddNewBill();
            this.Close();
        }
    }
}
