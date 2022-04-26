using Microsoft.EntityFrameworkCore;
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

namespace CleaningSystem
{
    /// <summary>
    /// Interaction logic for Tasks.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        private List<Service> serviceList;

        public Tasks()
        {
            InitializeComponent();
        }

        public Tasks(List<Service> services) : this()
        {
            foreach (Service service in services)
            {
                Service.Items.Add(service);
            }

            serviceList = services;
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close(); //Lukker gammel side 
        }

        void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Service service = ((ListViewItem)sender).Content as Service;

            new Edit(service).Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Tasks(serviceList).Show();
            Close();
        }
    }
    }
