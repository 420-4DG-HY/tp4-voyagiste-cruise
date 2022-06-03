using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using CruiseDTO;

using CommonDataDTO;

namespace CruiseDAL
{
    public interface ICruiseDataAccess
    {
        public Cruise[] GetAvailableCruises();
        public Cruise? GetCruise(Guid CruiseId);
        public Cabin? GetCabin(Guid CabinId);
        public CruiseAvailability[] GetCruiseAvailabilities(Cruise cruise);
        public CruiseAvailability[] GetCruiseAvailabilities(Cabin cabin);
        public CruiseAvailability AddCruiseAvailability(Cabin cabin, DateTime From, DateTime To, Person rentedTo);
        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId);
        public CruiseBooking[] GetCruiseBookings(Person rentedTo);
        public CruiseBooking[] GetCruiseBookings(Cabin cabin);
        public CruiseBooking Book(Cabin cabin, DateTime from, DateTime To, Person rentedTo);

        public BookingConfirmation ConfirmBooking(CruiseBooking booking);
        public BookingConfirmation? GetBookingConfirmation(CruiseBooking booking);

        public BookingCancellation CancelBooking(CruiseBooking booking);
        public BookingCancellation? GetBookingCancellation(CruiseBooking booking);
    }

    public class CruiseDataAccess : ICruiseDataAccess
    {
        private IConfiguration _configuration;
        private ILogger _logger;

        public CruiseDataAccess(IConfiguration configuration, ILogger<CruiseDataAccess> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public CruiseAvailability AddCruiseAvailability(Cabin cabin, DateTime From, DateTime To, Person rentedTo) {
            throw new NotImplementedException();
        }

        public CruiseBooking Book(Cabin cabin, DateTime from, DateTime To, Person rentedTo) {
            throw new NotImplementedException();
        }

        public BookingCancellation CancelBooking(CruiseBooking booking) {
            throw new NotImplementedException();
        }

        public BookingConfirmation ConfirmBooking(CruiseBooking booking) {
            throw new NotImplementedException();
        }

        public Cruise[] GetAvailableCruises() {
            throw new NotImplementedException();
        }

        public BookingCancellation? GetBookingCancellation(CruiseBooking booking) {
            throw new NotImplementedException();
        }

        public BookingConfirmation? GetBookingConfirmation(CruiseBooking booking) {
            throw new NotImplementedException();
        }

        public Cabin? GetCabin(Guid CabinId) {
            throw new NotImplementedException();
        }

        public Cruise? GetCruise(Guid CruiseId) {
            throw new NotImplementedException();
        }

        public CruiseAvailability[] GetCruiseAvailabilities(Cruise cruise) {
            throw new NotImplementedException();
        }

        public CruiseAvailability[] GetCruiseAvailabilities(Cabin cabin) {
            throw new NotImplementedException();
        }

        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId) {
            throw new NotImplementedException();
        }

        public CruiseBooking[] GetCruiseBookings(Person rentedTo) {
            throw new NotImplementedException();
        }

        public CruiseBooking[] GetCruiseBookings(Cabin cabin) {
            throw new NotImplementedException();
        }
    }
}
