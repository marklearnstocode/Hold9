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
        
        
        public string MovieGenre;
        public double MovieLength;
        public string MovieInstructor;
        public DateTime? PremiereDate; 

        public string MovieTitle { get; set; }
        public DateTime? PlayTime { get; set; }
        public DateTime Date { get; set; }
        public int CinemaHall { get; set; }
        public string City { get; set; }
        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{MovieTitle}; Playtime {PlayTime}; Date {Date}; CinemaHall {CinemaHall}; City {City}; Ticket amount {TicketAmount}; Email {Email}; Phonenumber {PhoneNumber}";
        }
        
        public Booking(string movieTitle, DateTime playTime, DateTime date, int cinemaHall, string city, int ticketAmount, string email, int phoneNumber)
        {
            this.MovieTitle = movieTitle;
            this.PlayTime = playTime;
            this.Date = date;
            this.CinemaHall = cinemaHall;
            this.City = city;
            this.TicketAmount = ticketAmount;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
}
