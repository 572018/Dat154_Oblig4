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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private dat154_2022_6Context dx = new dat154_2022_6Context();

        public Service service;

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Service Service)
        {
            InitializeComponent();

            service = Service;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Note.Text != null)
            {
                service.Note = Note.Text;
            }

            if (Status.Text != null)
            {
                service.Status = Status.Text;
            }

            dx.Services.Update(service);

            Close();
        }
    }
}
