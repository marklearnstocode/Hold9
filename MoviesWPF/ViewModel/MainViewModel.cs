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
        private BookingRepo bookingRepo = new BookingRepo();
        public void AddBooking()
        {
            Booking booking = AddBooking();
            PersonViewModel PVM1 = new PersonViewModel(person);
            PersonsVM.Add(PVM1);
            SelectedPerson = PVM1;
        }
    }
}
