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
using WpfApplication.UI.Home;
using WpfApplication.UI.Client;
using WpfApplication.ModelViews;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  ModelView modelView;
        bool move = false;
        Point point;
        public MainWindow()
        {
            InitializeComponent();
            this.contentControl.Content = new HomeHome();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //modelView.GetBuildingList();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = new HomeHome();
        }

        private void Buildings_Click(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = new BuildingHome();
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = new ClientHome();
        }

        private void wrapPanel1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            move = true;
            point = e.GetPosition(this);
        }

        private void wrapPanel1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            move = false;
        }

        private void wrapPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.Left += e.GetPosition(this).X - point.X;
                this.Top += e.GetPosition(this).Y - point.Y;
                point = e.GetPosition(this);
            }


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void buttonMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }
    }
}
