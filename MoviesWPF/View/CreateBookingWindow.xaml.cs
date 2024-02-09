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

namespace MoviesWPF.View
{
    /// <summary>
    /// Interaction logic for CreateBooking.xaml
    /// </summary>
    public partial class CreateBooking : Window
    {
        public CreateBooking()
        {
            InitializeComponent();
            PreviewKeyDown += (s, e) => 
            { if (e.Key == Key.Escape) 
                    Close(); 
            };
        }
        private void TitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void PlayTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CinemaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TicketAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
  
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void PhoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MoviesWPF.MainWindow();
            this.Visibility = Visibility.Collapsed;
            mainWindow.Show();

        }

    }
}
