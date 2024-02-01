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

            BookingRepo br = new BookingRepo();
            br.Bookings = new List<Booking>();
            br.Bookings.Add(Cinemaxx; Odense; 2020 - 04 - 03 21:00; 1917; Drama, Thriller, War; 01:57; Sam Mendes; 2020 - 01 - 10; djupedal @live.com; 94816860);
        }
    }
}