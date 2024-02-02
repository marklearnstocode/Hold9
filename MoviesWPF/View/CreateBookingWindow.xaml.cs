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
            TicketAmountlb.Visibility = Visibility.Visible;
        
            if (TicketAmountTextBox != null)
            {
                TicketAmountlb.Visibility = Visibility.Collapsed;
            }    
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox box)
            {
                if (string.IsNullOrEmpty(box.Text))
                    box.Background = (ImageBrush)FindResource("Email");
                else
                    box.Background = null;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox box)
            {
                if (string.IsNullOrEmpty(box.Text))
                    box.Background = (ImageBrush)FindResource("Phone Number");
                else
                    box.Background = null;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MoviesWPF.MainWindow();
            this.Visibility = Visibility.Collapsed;
            mainWindow.Show();

        }

    }
}
