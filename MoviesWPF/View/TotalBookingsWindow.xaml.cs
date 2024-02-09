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
    /// Interaction logic for TotalBookingsWindow.xaml
    /// </summary>
    public partial class TotalBookingsWindow : Window
    {
        public TotalBookingsWindow()
        {
            InitializeComponent();
            PreviewKeyDown += (s, e) =>
            {
                if (e.Key == Key.Escape)
                    Close();
            };
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            MoviesWPF.View.UpdateBookingWindow updateBooking = new MoviesWPF.View.UpdateBookingWindow();
            this.Visibility = Visibility.Hidden;
            updateBooking.ShowDialog();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
