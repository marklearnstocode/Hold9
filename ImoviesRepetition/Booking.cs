using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImoviesRepetition
{
    public class Booking
    {
        public string MovieTitle {  get; set; }
        public DateTime PlayTime { get; set; }
        public int CinemaHall { get; set; }

        public int TicketAmount { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }

    }
}
