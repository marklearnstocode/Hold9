using MoviesWPF.Model;
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
using MoviesWPF.Persistence;
using System.Windows.Media;
using MoviesWPF.ViewModel;
using System.Drawing;

namespace MoviesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window    
    {
        MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) Close(); };
            DataContext = mvm;
        }
        private void CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            MoviesWPF.View.CreateBooking createBooking = new MoviesWPF.View.CreateBooking();
            this.Visibility = Visibility.Hidden;
            createBooking.ShowDialog();
        }

        //private void UpdateBooking_Click(object sender, RoutedEventArgs e)
        //{
        //    MoviesWPF.View.UpdateBookingWindow updateBooking = new MoviesWPF.View.UpdateBookingWindow();
        //    this.Visibility = Visibility.Hidden;
        //    updateBooking.ShowDialog();
        //}

        private void GetTotalBookings_Click(object sender, RoutedEventArgs e)
        {
            MoviesWPF.View.TotalBookingsWindow totalBookings = new MoviesWPF.View.TotalBookingsWindow();
            this.Visibility = Visibility.Hidden;
            totalBookings.ShowDialog();
        }

        // default color #FF4F33DF
        // hover color #FF6C55E2
        
        SolidColorBrush defaultbrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 79, 51, 223));
        SolidColorBrush hoverbrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 108, 85, 226));

        private void GetTotalBookings_MouseEnter(object sender, MouseEventArgs e)
        {
            GetTotalBookings.Background = hoverbrush;
        }
        private void GetTotalBookings_MouseLeave(object sender, MouseEventArgs e)
        {
            GetTotalBookings.Background = defaultbrush;
        }
        private void CreateBooking_MouseEnter(object sender, MouseEventArgs e)
        {
            CreateBooking.Background = hoverbrush;
        }
        private void CreateBooking_MouseLeave(object sender, MouseEventArgs e)
        {
            CreateBooking.Background = defaultbrush;
        }

        //private void DeleteBooking_Click(object sender, RoutedEventArgs e)
        //{
        //    MoviesWPF.View.DeleteBookingWindow deleteBooking = new MoviesWPF.View.DeleteBookingWindow();
        //    this.Visibility = Visibility.Hidden;
        //    deleteBooking.ShowDialog();
        //}
    }
}
