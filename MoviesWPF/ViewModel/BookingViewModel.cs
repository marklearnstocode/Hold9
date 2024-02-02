using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Persistence;
using MoviesWPF.Model;

namespace MoviesWPF.ViewModel
{
    public class BookingViewModel
    {
        private Booking booking;
        public string MovieTitle { get; set; }
        public DateTime PlayTime { get; set; }
        public int CinemaHall { get; set; }
        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public BookingViewModel(Booking booking) 
        {
            this.MovieTitle = booking.MovieTitle;
            this.PlayTime = booking.PlayTime;
            this.CinemaHall = booking.CinemaHall;
            this.TicketAmount = booking.TicketAmount;
            this.Email = booking.Email;
            this.PhoneNumber = booking.PhoneNumber;
        }
    }
}
