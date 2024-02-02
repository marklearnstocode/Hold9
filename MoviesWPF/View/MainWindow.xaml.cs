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

namespace MoviesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) Close(); };
        }
        private void CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            MoviesWPF.View.CreateBooking createBooking = new MoviesWPF.View.CreateBooking();
            this.Visibility = Visibility.Hidden;
            createBooking.ShowDialog();

        }
    }
}
