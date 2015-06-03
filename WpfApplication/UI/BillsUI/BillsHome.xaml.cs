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
using WpfApplication.ModelViews.BillsModelViews;
using WpfApplication.ModelViews.ClientModelViews;

namespace WpfApplication.UI.BillsUI
{
    /// <summary>
    /// Interaction logic for HomeHome.xaml
    /// </summary>
    public partial class BillsHome : UserControl
    {

        BillsModelView modelView;

        public BillsHome()
        {
            InitializeComponent();
            try
            {
                modelView = new BillsModelView();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            DataContext = modelView;
        }

        private void buttonActualMonth_Click(object sender, RoutedEventArgs e)
        {
            // display list of clients from actual month with status of payment
            // status: to settle
            //         settled
            //         paid
        }

        private void buttonPreviousMonths_Click(object sender, RoutedEventArgs e)
        {
            // display list of clients from previous months with status of payment (to see if everyone paid)
        }      
    }
}
