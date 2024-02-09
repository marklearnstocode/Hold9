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
    /// Interaction logic for UpdateBookingWindow.xaml
    /// </summary>
    public partial class UpdateBookingWindow : Window
    {
        public UpdateBookingWindow()
        {
            InitializeComponent();
            PreviewKeyDown += (s, e) =>
            {
                if (e.Key == Key.Escape)
                    Close();
            };
        }
    }
}
