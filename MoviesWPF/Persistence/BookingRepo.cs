using MoviesWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MoviesWPF.Persistence
{
    public class BookingRepo
    {

        string? ConnectionString;

        private List<Booking> Bookings;
        public BookingRepo()
        {
            Bookings = new List<Booking>();

            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? ConnectionString = config.GetConnectionString("MyDBConnection");

        }

        public void Create(Booking bookingToBeCreated)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Booking (PlayTime, CinemaHall, TicketAmount, Email, PhoneNumber, MovieTitle)" +
                                                 "VALUES(@PlayTime,@CinemaHall,@TicketAmount,@Email,@PhoneNumber,@MovieTitle)" +
                                                 "SELECT @@IDENTITY", con);
                cmd.Parameters.Add("@PlayTime", SqlDbType.DateTime2).Value = bookingToBeCreated.PlayTime;
                cmd.Parameters.Add("@CinemaHall", SqlDbType.Int).Value = bookingToBeCreated.CinemaHall;
                cmd.Parameters.Add("@TicketAmount", SqlDbType.Int).Value = bookingToBeCreated.TicketAmount;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = bookingToBeCreated.Email;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.Int).Value = bookingToBeCreated.PhoneNumber;
                cmd.Parameters.Add("@MovieTitle", SqlDbType.NVarChar).Value = bookingToBeCreated.MovieTitle;
                bookingToBeCreated.Id = Convert.ToInt32(cmd.ExecuteScalar());
                Bookings.Add(bookingToBeCreated);
            }
        }

        public void RetrieveAll()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("SELECT PlayTime, CinemaHall, TicketAmount, Email, PhoneNumber, MovieTitle FROM Booking", con); using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Booking booking = new Booking
                        {
                            Id = int.Parse(dr["Id"].ToString()),
                            PlayTime = DateTime.Parse(dr["PlayTime"].ToString()),
                            CinemaHall = int.Parse(dr["CinemaHall"].ToString()),
                            TicketAmount = int.Parse(dr["TicketAmount"].ToString()),
                            Email = dr["Email"].ToString(),
                            PhoneNumber = int.Parse(dr["PhoneNumber"].ToString()),
                            MovieTitle = dr["PhoneNumber"].ToString()
                        }; 
                        Bookings.Add(booking);
                    }
                }
            }
        }

        public void Update(Booking bookingToBeUpdated)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("UPDATE booking SET PlayTime = @PlayTime, CinemaHall = @CinemaHall, TicketAmount = @TicketAmount, Email = @Email, PhoneNumber = @PhoneNumber, MovieTitle = @MovieTitle WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = bookingToBeUpdated.Id;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(Booking bookingToBeDeleted)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open(); SqlCommand cmd = new SqlCommand("DELETE FROM Booking WHERE Id = @Id", con);
                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = bookingToBeDeleted.Id;
                cmd.ExecuteNonQuery();
            }
            Bookings.Remove(bookingToBeDeleted);
        }
        //public void AddBooking(string allInfo)
        //{
        //    Booking newBooking = new Booking();
        //    string[] infoParts = allInfo.Split(";");
        //    newBooking.CinemaHall = Convert.ToInt32(infoParts[0]);
        //    newBooking.City = infoParts[1];
        //    newBooking.PlayTime = Convert.ToDateTime(infoParts[2]);
        //    newBooking.MovieTitle = infoParts[3];
        //    newBooking.MovieGenre = infoParts[4];
        //    newBooking.MovieLength = Convert.ToDouble(infoParts[5]);
        //    newBooking.MovieInstructor = infoParts[6];
        //    newBooking.PremiereDate = Convert.ToDateTime(infoParts[7]);
        //    newBooking.Email = infoParts[8];
        //    newBooking.PhoneNumber = Convert.ToInt32(infoParts[9]);

        //    Bookings.Add(newBooking);
        //}
        //public List<Booking> GetTotalBookings(string movieTitle, DateTime playtime)
        //{
        //    List<Booking> bookingsFound = new List<Booking>(); // Create the list we'll use to return at end of method, if we found any results matching method input-parameters
        //    foreach (Booking booking in Bookings)
        //    {
        //        if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            bookingsFound.Add(booking);
        //    }
        //    return bookingsFound;
        //}
        //public void UpdateBooking(string movieTitle, DateTime playtime, DateTime newPlayTime)
        //{
        //    List<Booking> bookingsFound = new List<Booking>();

        //    foreach (Booking booking in Bookings)
        //    {
        //        if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            booking.PlayTime = newPlayTime;
        //    }
        //}
        //public void DeleteBooking(string movieTitle, DateTime playtime)
        //{
        //    List<Booking> bookingsFound = new List<Booking>();
        //    foreach (Booking booking in Bookings)
        //    {
        //        if (booking.MovieTitle == movieTitle && booking.PlayTime == playtime)
        //            bookingsFound.Remove(booking);
        //    }
        //}
        //public List<Booking> GetAll()
        //{
        //    return Bookings;
        //}

        //public void Load_From_CSV()
        //{
        //    try
        //    {
        //        using (StreamReader sr = new StreamReader("Pr38_TheMovies.CSV"))
        //        {
        //            string line = sr.ReadLine();
        //            string[] fields = line.Split(';');

        //            while ((line = sr.ReadLine()) != null)
        //            {
        //                Console.WriteLine(line);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Booking couldn't load");
        //        Console.WriteLine(e.Message);
        //    }

        //}

        //public void Save_To_CSV()
        //{
        //    using (StreamWriter sw = new StreamWriter("Pr38_TheMovies.CSV"))
        //    {
        //        sw.WriteLine("Biograf;By;Forestillingstidspunkt;Filmtitel;Filmgenre;Filmvarighed;Filminstruktør;Premieredato;Bookingmail;Bookingtelefonnummer"); // Initial format-definition line, as gotten from provided customer data file(s)

        //        foreach (Booking booking in Bookings)
        //        {
        //            sw.WriteLine($"{booking.CinemaHall};{booking.City};{booking.PlayTime};{booking.MovieGenre};{booking.MovieLength};{booking.MovieInstructor};{booking.PremiereDate};{booking.Email};{booking.PhoneNumber}");
        //        }
        //    }



    }
}



