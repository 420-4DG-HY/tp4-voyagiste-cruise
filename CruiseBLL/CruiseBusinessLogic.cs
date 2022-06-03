using CommonDataDTO;
using CruiseDTO;
using CruiseDAL;

using Microsoft.Extensions.Logging;

namespace CruiseBLL
{
    public interface ICruiseBusinessLogic
    {
        public Cruise[] GetAvailableCruises();
        public CruiseAvailability[] GetCruiseAvailabilities(Cruise cruise);
        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId);
        public Cruise? GetCruise(Guid CruiseId);
        public Cabin? GetCabin(Guid CabinId);
        public CruiseBooking Book(Guid CabinId, DateTime from, DateTime To, Person rentedTo);

        public BookingConfirmation ConfirmBooking(CruiseBooking booking);
        public BookingConfirmation? GetBookingConfirmation(CruiseBooking booking);

        public BookingCancellation CancelBooking(CruiseBooking booking);
        public BookingCancellation? GetBookingCancellation(CruiseBooking booking);
    }

    public class CruiseBusinessLogic : ICruiseBusinessLogic
    {
        readonly ILogger<CruiseBusinessLogic> _logger;
        readonly ICruiseDataAccess _dal;

        public CruiseBusinessLogic(ICruiseDataAccess dataAccess, ILogger<CruiseBusinessLogic> logger)
        {
            _dal = dataAccess;
            _logger = logger;
        }

        public CruiseBooking Book(Guid CabinId, DateTime from, DateTime To, Person rentedTo) {
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

        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId) {
            throw new NotImplementedException();
        }
    }
}