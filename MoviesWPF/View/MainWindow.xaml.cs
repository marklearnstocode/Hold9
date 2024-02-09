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


using MoviesWPF.Persistence;
using MoviesWPF.ViewModel;
using MoviesWPF.View;

namespace MoviesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        CreateBooking createBookingWindow;

        public MainWindow()
        {
            mainViewModel = new MainViewModel();
            createBookingWindow = new CreateBooking();
            InitializeComponent();

            PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) Close(); };
        }
        private void CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            createBookingWindow.ShowDialog();
        }

        public void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
