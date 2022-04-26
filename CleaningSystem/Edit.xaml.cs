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

            if (service.Note != null)
            {
                Note.Text = service.Note;
            }

            if (service.Status != null)
            {
                Status.Text = service.Status;
            }
        }
        //<TextBox Name="Status" HorizontalAlignment="Left" Margin="181,140,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Top" Width="154" Height="26" RenderTransformOrigin="0.472,0.471" Grid.ColumnSpan="2" Grid.Column="1"/>
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Note.Text != null)
            {
                service.Note = Note.Text;
            }

            if (Status.SelectedItem != null)
            {
                service.Status = (string?)Status.SelectedItem;
            }

            if ((string?)Status.SelectedItem == "Done")
            {
                dx.Services.Remove(service);
                dx.SaveChanges();
            }
            else
            {
                dx.Services.Update(service);
                dx.SaveChanges();
            }

            Close();
        }
    }
}
