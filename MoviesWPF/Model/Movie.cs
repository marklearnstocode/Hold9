using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWPF.Model
{
    public class Movie
    {
        private DateTime playTime;

        public DateTime Playtime
        {
            set { playTime = value; }
            get { return playTime; }
        }

        public string MovieTitle { get; set; }

        public string Genre { get; set; }

        public int Duration { get; set; }
        public string Instructor { get; set; }
        
        public int CinemaHall { get; set; }


        public DateTime OpeningDate { get; set; }



    }
}
