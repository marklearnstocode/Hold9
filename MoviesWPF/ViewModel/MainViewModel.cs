using MoviesWPF.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesWPF.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MoviesWPF.ViewModel
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public static BookingRepo bookingRepo = new BookingRepo();

        private string movieTitle;

        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value;
                OnPropertyChanged(nameof(MovieTitle));
            }
        }

        private DateTime playTime;

        public DateTime PlayTime
        {
            get { return playTime; }
            set { playTime = value;
                OnPropertyChanged(nameof(PlayTime));
            }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        private int cinemaHall;

        public int CinemaHall
        {
            get { return cinemaHall; }
            set { cinemaHall = value;
                OnPropertyChanged(nameof(CinemaHall));
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        private int ticketAmount;

        public int TicketAmount
        {
            get { return ticketAmount; }
            set { ticketAmount = value;
                OnPropertyChanged(nameof(TicketAmount));
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private int phoneNumber;

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }



        public MainViewModel()
        {
            
        }
        private BookingViewModel selectedBooking;

        public BookingViewModel SelectedBooking
        {
            get { return selectedBooking; }
            set { selectedBooking = value; }
        }
        public int MyProperty { get; set; }

        public void SaveBooking()
        {
            // Create the object
            var newBooking = new Booking(this.MovieTitle, PlayTime, Date, CinemaHall, City, TicketAmount, Email, PhoneNumber);

            // Save/commit the object to the database
            bookingRepo.AddBooking(newBooking);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
