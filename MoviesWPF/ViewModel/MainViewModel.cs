using MoviesWPF.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Model;

namespace MoviesWPF.ViewModel
{
    public class MainViewModel
    {
        public static BookingRepo bookingRepo = new BookingRepo();
        public ObservableCollection<BookingViewModel> BookingsVM { get; set; }

        public MainViewModel()
        {
            BookingsVM = new ObservableCollection<BookingViewModel>();
            foreach (Booking booking in bookingRepo.GetAll())
            {
                BookingViewModel BVM = new BookingViewModel(booking);
                BookingsVM.Add(BVM);
            }
        }
        private BookingViewModel selectedBooking;

        public BookingViewModel SelectedBooking
        {
            get { return selectedBooking; }
            set { selectedBooking = value; }
        }


    }
}
