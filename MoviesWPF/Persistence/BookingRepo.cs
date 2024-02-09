using MoviesWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Model;
using System.IO;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoviesWPF.Persistence
{
    public class BookingRepo
    {
        string dataBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pr38_TheMovies.CSV");

        private List<Booking> Bookings;
        public BookingRepo()
        {
            Bookings = new List<Booking>();
        }

        public Booking AddBooking(string movieTitle, DateTime playTime, DateTime date, int cinemaHall, string city, int ticketAmount, string email, int phoneNumber)
        {
            Booking b = new Booking(movieTitle, playTime, date, cinemaHall, city, ticketAmount, email, phoneNumber);
            Bookings.Add(b);
            //string[] infoParts = booking.Split(";");
            //Booking newBooking = new Booking(infoParts[0], Convert.ToDateTime(infoParts[1]),
            //    Convert.ToInt32(infoParts[2]),
            //    Convert.ToInt32(infoParts[3]),
            //    infoParts[4],
            //    Convert.ToInt32(infoParts[5]));
            //Bookings.Add(newBooking);
            return b;
        }
        //    public List<Booking> GetTotalBookings(string movieTitle, DateTime playtime)
        //    {
        //        List<Booking> bookingsFound = new List<Booking>(); // Create the list we'll use to return at end of method, if we found any results matching method input-parameters
        //        foreach (Booking booking in Bookings)
        //        {
        //            if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            {

        //                bookingsFound.Add(booking);
        //            }
        //        }
        //        return bookingsFound;
        //    }
        //    public void UpdateBooking(string movieTitle, DateTime playtime, DateTime newPlayTime)
        //    {
        //        List<Booking> bookingsFound = new List<Booking>();

        //        foreach (Booking booking in Bookings)
        //        {
        //            if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            {

        //                booking.PlayTime = newPlayTime;
        //            }
        //        }
        //    }
        //    public void DeleteBooking(string movieTitle, DateTime playtime)
        //    {
        //        List<Booking> bookingsFound = new List<Booking>();
        //        foreach (Booking booking in Bookings)
        //        {
        //            if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            {

        //                bookingsFound.Remove(booking);
        //            }
        //        }
        //    }
        //    public List<Booking> GetAll()
        //    {
        //        return Bookings;
        //    }

        //    public void Load_From_CSV()
        //    {
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader("Pr38_TheMovies.CSV"))
        //            {
        //                string line = sr.ReadLine();
        //                string[] fields = line.Split(';');

        //                while ((line = sr.ReadLine()) != null)
        //                {
        //                    Console.WriteLine(line);
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Booking couldn't load");
        //            Console.WriteLine(e.Message);
        //        }

        //    }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(dataBase, true))
            {
                foreach (Booking booking in Bookings)
                {
                    string output = booking.ToString();
                    sw.WriteLine(output);
                }
                
            }


        }
        public Booking AddBooking(Booking booking)
        {
            Bookings.Add(booking);
            return booking;
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


