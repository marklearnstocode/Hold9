using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWPF.Model
{
    public class Booking
    {
        private static int idCount = 0;
        public int Id { get; }
        public string MovieTitle {  get; set; }
        public DateTime PlayTime { get; set; }
        public int CinemaHall { get; set; }

        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }
        public string FullBooking
        {
            get { return Email + " " + Phonenumber + " " + TicketAmount + " " + MovieTitle + " " + PlayTime + " " + CinemaHall; }
        }
        public Booking()
        {
            Id = idCount++;
        }
        public override string ToString()
        {
            return $"{Email}: {Phonenumber}: {TicketAmount} Tickets: {MovieTitle}: {PlayTime} Playtime: Location {CinemaHall}"; 
        }
    }
}
