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
        public CruiseBooking Book(Cruise cruise,Cabin cabin, DateTime from, DateTime To, Person rentedTo);

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

        public CruiseBooking Book(Cruise cruise,Cabin cabin, DateTime from, DateTime To, Person rentedTo) {
            var booking = new CruiseBooking(new Guid(), rentedTo, cruise, cabin, from);
            FakeData.GetInstance().cruiseBookings.Add(booking);
            return booking;
        }

        public BookingCancellation CancelBooking(CruiseBooking booking) {
            BookingCancellation bc = new BookingCancellation(new Guid(), booking, new DateTime());
            FakeData.GetInstance().bookingCancellations.Add(bc);
            return bc;
        }

        public BookingConfirmation ConfirmBooking(CruiseBooking booking) {
            BookingCancellation? bBancel = GetBookingCancellation(booking);
            if (bBancel != null)
            {
                string message = "Cannot confirm booking : \n" + booking + " \nBecause it has been cancelled by : \n" + bBancel;
                _logger.LogError(message);
                throw new Exception(message);
            }
            else
            {
                BookingConfirmation confirmation = new BookingConfirmation(new Guid(), booking, new DateTime());
                FakeData.GetInstance().bookingConfirmations.Add(confirmation);
                return confirmation;
            }
        }

        public Cruise[] GetAvailableCruises() {
            //return FakeData.cruises.Select(c => c.ship).Distinct().ToArray();
            throw new NotImplementedException();
        }

        public BookingCancellation? GetBookingCancellation(CruiseBooking booking) {
            return FakeData.GetInstance().bookingCancellations.Where(bc => bc.Booking == booking).FirstOrDefault();
        }

        public BookingConfirmation? GetBookingConfirmation(CruiseBooking booking) {
            return FakeData.GetInstance().bookingConfirmations.Where(bc => bc.Booking == booking).FirstOrDefault();
        }

        public Cabin? GetCabin(Guid CabinId) {
            return FakeData.cabins.Where(c => c.CabinGuid == CabinId).FirstOrDefault();
        }

        public Cruise? GetCruise(Guid CruiseId) {
            return FakeData.cruises.Where(c => c.CruiseGuid == CruiseId).FirstOrDefault();
        }

        public CruiseAvailability[] GetCruiseAvailabilities(Cruise cruise) {
            throw new NotImplementedException();
        }

        public CruiseAvailability[] GetCruiseAvailabilities(Cabin cabin) {
            throw new NotImplementedException();
        }

        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId) {
            return FakeData.GetInstance().cruiseBookings.Where(cb => cb.CruiseBookingGuid == CruiseBookingId).FirstOrDefault();
        }

        public CruiseBooking[] GetCruiseBookings(Person rentedTo) {
            throw new NotImplementedException();
        }

        public CruiseBooking[] GetCruiseBookings(Cabin cabin) {
            throw new NotImplementedException();
        }
    }
}
