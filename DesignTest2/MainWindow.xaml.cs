using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignTest2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClassesDataContext dC1DC = new DataClassesDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Menu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Clients_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Table.ItemsSource = null;
            Table.ItemsSource = from client in dC1DC.Clients select client;
        }

        private void Service_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Table.ItemsSource = null;
            Table.ItemsSource = from client in dC1DC.Service select client;
        }

        private void Work_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Table.ItemsSource = null;
            Table.ItemsSource = from client in dC1DC.Work select client;
        }

    }
}
