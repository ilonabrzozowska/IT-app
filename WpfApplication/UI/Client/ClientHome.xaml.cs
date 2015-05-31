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

namespace WpfApplication.UI.Client
{
    /// <summary>
    /// Interaction logic for HomeHome.xaml
    /// </summary>
    public partial class ClientHome : UserControl
    {

        public ClientHome()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void buttonDownload_Click(object sender, RoutedEventArgs e)
        {
            client.ItemsSource = BusinessLayer.Service.GetAllUsers();
        }

        
    }
}
