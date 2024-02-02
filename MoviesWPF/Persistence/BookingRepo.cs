using MoviesWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Model;
using System.IO;

namespace MoviesWPF.Persistence
{
    public class BookingRepo
    {
        private List<Booking> Bookings;
        public BookingRepo()
        {
            Bookings = new List<Booking>();
        }

        public void AddBooking(string allInfo)
        {
            Booking newBooking = new Booking();
            string[] infoParts = allInfo.Split(";");
            newBooking.CinemaHall = Convert.ToInt32(infoParts[0]);
            newBooking.City = infoParts[1];
            newBooking.PlayTime = Convert.ToDateTime(infoParts[2]);
            newBooking.MovieTitle = infoParts[3];
            newBooking.MovieGenre = infoParts[4];
            newBooking.MovieLength = Convert.ToDouble(infoParts[5]);
            newBooking.MovieInstructor = infoParts[6];
            newBooking.PremiereDate = Convert.ToDateTime(infoParts[7]);
            newBooking.Email = infoParts[8];
            newBooking.PhoneNumber = Convert.ToInt32(infoParts[9]);

            Bookings.Add(newBooking);
        }
        public List<Booking> GetTotalBookings(string movieTitle, DateTime playtime)
        {
            List<Booking> bookingsFound = new List<Booking>(); // Create the list we'll use to return at end of method, if we found any results matching method input-parameters
            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    bookingsFound.Add(booking);
            }
            return bookingsFound;
        }
        public void UpdateBooking(string movieTitle, DateTime playtime, DateTime newPlayTime)
        {
            List<Booking> bookingsFound = new List<Booking>();

            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    booking.PlayTime = newPlayTime;
            }
        }
        public void DeleteBooking(string movieTitle, DateTime playtime)
        {
            List<Booking> bookingsFound = new List<Booking>();
            foreach (Booking booking in Bookings)
            {
                if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
                    bookingsFound.Remove(booking);
            }
        }

        public void Load_From_CSV()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Pr38_TheMovies.CSV"))
                {
                    string line = sr.ReadLine();
                    string[] fields = line.Split(';');

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Booking couldn't load");
                Console.WriteLine(e.Message);
            }

        }

        public void Save_To_CSV()
        {
            using (StreamWriter sw = new StreamWriter("Pr38_TheMovies.CSV"))
            {
                sw.WriteLine("Biograf;By;Forestillingstidspunkt;Filmtitel;Filmgenre;Filmvarighed;Filminstruktør;Premieredato;Bookingmail;Bookingtelefonnummer"); // Initial format-definition line, as gotten from provided customer data file(s)

                foreach (Booking booking in Bookings)
                {
                    sw.WriteLine($"{booking.CinemaHall};{booking.City};{booking.PlayTime};{booking.MovieGenre};{booking.MovieLength};{booking.MovieInstructor};{booking.PremiereDate};{booking.Email};{booking.PhoneNumber}");
                }
            }

        }
    }

}

//#region csv_stuff
//public void Load_From_CSV()
//{

//}

//public void Save_To_CSV()
//{
//    // Using so the program automatically disposes & Closes() the file after operation is done
//    using (Streamwriter sw = new Streamwriter())
//    {
//        sw.WriteLine("Biograf;By;Forestillingstidspunkt;Filmtitel;Filmgenre;Filmvarighed;Filminstruktør;Premieredato;Bookingmail;Bookingtelefonnummer"); // Initial format-definition line, as gotten from provided customer data file(s)

//        foreach (Booking booking in Bookings)
//        {
//            sw.WriteLine($"{booking.Cinema};{booking.City};{booking.PlayTime};{booking.MovieGenre};{booking.MovieLength};{booking.MovieInstructor};{booking.PremiereDate};{booking.Email};{booking.PhoneNumber}");
//        }
//    }
//}
//#endregion csv_stuff


