using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImoviesRepetition.Persistence
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
            List <Booking> = new List<Booking>(); // Create the list we'll use to return at end of method, if we found any results matching method input-parameters
            foreach (Booking booking in Bookings)
            {
                if ()
            }
            return Bookings;
        }
    }
}
