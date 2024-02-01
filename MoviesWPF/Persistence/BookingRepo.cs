using MoviesWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Model;

namespace MoviesWPF.Persistence
{
    public class BookingRepo
    {
        public List<Booking> Bookings;

        public void AddBooking(string allInfo)
        {
            Booking newBooking = new Booking();
            string[] infoParts = allInfo.Split(";");
            newBooking.Cinema = infoParts[0];
            newBooking.City = infoParts[1];
            newBooking.PlayTime = infoParts[2];
            newBooking.MovieTitle = infoParts[3];
            newBooking.MovieGenre = infoParts[4];
            newBooking.MovieLength = infoParts[5];
            newBooking.MovieInstructor = infoParts[6];
            newBooking.PremiereDate = infoParts[7];
            newBooking.Email = infoParts[8];
            newBooking.PhoneNumber = infoParts[9];

        Bookings.Add();
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
            sw.WriteLine("Biograf;By;Forestillingstidspunkt;Filmtitel;Filmgenre;Filmvarighed;Filminstruktør;Premieredato;Bookingmail;Bookingtelefonnummer"); // Initial format-definition line, as gotten from provided customer data file(s)

            foreach (Booking booking in Bookings)
            {
                sw.WriteLine($"{booking.Cinema};{booking.City};{booking.PlayTime};{booking.MovieGenre};{booking.MovieLength};{booking.MovieInstructor};{booking.PremiereDate};{booking.Email};{booking.PhoneNumber}");
            }
        }
    }
    #endregion csv_stuff
}
}
