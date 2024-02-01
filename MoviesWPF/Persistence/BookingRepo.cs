using MoviesWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWPF.Persistence
{
    public class BookingRepo
    {
        public List<Booking> Bookings;

        public void AddBooking()
        {
            Bookings.Add(NewBookingConstructor);
        }
        public List<Booking> GetTotalBookings(string movieTitle, DateTime playtime)
        {
            List<Booking> bookingsFound = new List<Booking>(); // Create the list we'll use to return at end of method, if we found any results matching method input-parameters
            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    bookingsFound.Add(booking);
            }
            return Bookings;
        }
        public List<Booking> UpdateBooking(string movieTitle, DateTime playtime, DateTime newPlayTime)
        {
            List<Booking> bookingsFound = new List<Booking>();

            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    booking.PlayTime = newPlayTime;
            }
        }
        public List<Booking> DeleteBooking(string movieTitle, DateTime playtime)
        {
            List<Booking> bookingsFound = new List<Booking>();
            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    bookingsFound.Remove(booking);
            }
        }
    }

    #region csv_stuff
    public void Load_From_CSV()
    {
        
    }

    public void Save_To_CSV()
    {
        // Using so the program automatically disposes & Closes() the file after operation is done
        using (Streamwriter sw = new Streamwriter())
        {
            foreach (Booking booking in Bookings)
            {
                sw.WriteLine();
            }
        }
    }
    #endregion csv_stuff
}
}
