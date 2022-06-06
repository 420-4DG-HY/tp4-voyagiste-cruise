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
            Cruise? cruise = _dal.GetCruise(CabinId);
            if (cruise == null)
            {
                string message = "Invalid Cruise GUID: "+CabinId;
                _logger.LogError(message);
                throw new Exception(message);
            }
            return Book(CabinId,from,To, rentedTo);
        }

        public BookingCancellation CancelBooking(CruiseBooking bk) {
            _dal.AddCruiseAvailability(bk.Cabin,bk.BookedWhen,bk.BookedWhen,bk.Person);
            GetCruiseAvailabilities(bk.Cruise);
            return CancelBooking(bk);
        }

        public BookingConfirmation ConfirmBooking(CruiseBooking booking) {
            return _dal.ConfirmBooking(booking);
        }

        public Cruise[] GetAvailableCruises() {
            return _dal.GetAvailableCruises();
        }

        public BookingCancellation? GetBookingCancellation(CruiseBooking booking) {
            return _dal.GetBookingCancellation(booking);
        }

        public BookingConfirmation? GetBookingConfirmation(CruiseBooking booking) {
            return _dal.GetBookingConfirmation(booking);
        }

        public Cabin? GetCabin(Guid CabinId) {
            return _dal.GetCabin(CabinId);
        }

        public Cruise? GetCruise(Guid CruiseId) {
            return _dal.GetCruise(CruiseId);
        }

        public CruiseAvailability[] GetCruiseAvailabilities(Cruise cruise) {
            return _dal.GetCruiseAvailabilities(cruise);
        }

        public CruiseBooking? GetCruiseBooking(Guid CruiseBookingId) {
            return _dal.GetCruiseBooking(CruiseBookingId);
        }
    }
}