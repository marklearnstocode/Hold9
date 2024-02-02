using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MoviesWPF.Model
{
    public class Booking
    {
        public string City;
        public string MovieGenre;
        public double MovieLength;
        public string MovieInstructor;
        public DateTime? PremiereDate; 

        public string MovieTitle { get; set; }
        public DateTime? PlayTime { get; set; }
        public int CinemaHall { get; set; }

        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{MovieTitle}; Playtime {PlayTime}; {CinemaHall}; Ticket amount {TicketAmount}; Email {Email}; Phonenumber {PhoneNumber}";
        }
        public Booking(string city, string movieGenre, double movieLength, string movieInstructor, DateTime? premiereDate, string movieTitle, DateTime? playTime, int cinemaHall, int ticketAmount, string email, int phoneNumber)
        {
            City = city;
            MovieGenre = movieGenre;
            MovieLength = movieLength;
            MovieInstructor = movieInstructor;
            PremiereDate = premiereDate;
            MovieTitle = movieTitle;
            PlayTime = playTime;
            CinemaHall = cinemaHall;
            TicketAmount = ticketAmount;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public Booking(string movieTitle, DateTime playTime, int cinemaHall, int ticketAmount, string email, int phoneNumber): this(null, null, 0, null, null, movieTitle, playTime, 0, ticketAmount, email, phoneNumber)
        {

        }
        public Booking(): this(null, null, 0, null, null, null, null, 0, 0, null, 0)
        {

        }
    }
}
