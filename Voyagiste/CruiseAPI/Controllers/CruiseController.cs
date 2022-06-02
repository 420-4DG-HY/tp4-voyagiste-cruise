using CommonDataDTO;
using CruiseBLL;
using CruiseDTO;
using Microsoft.AspNetCore.Mvc;

namespace CruiseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CruiseController : ControllerBase
    {
        private readonly ILogger<CruiseController> _logger;
        private readonly ICruiseBusinessLogic _bll;

        public CruiseController(ICruiseBusinessLogic businessLogic, ILogger<CruiseController> logger)
        {
            _logger = logger;
            _bll = businessLogic;
        }

        [HttpGet("GetAvailableCruises")]
        public Cruise[] GetAvailableCruises() {
            return _bll.GetAvailableCruises();
        }

        [HttpGet("CruiseAvailabilities/{CruiseGuid}")]
        public CruiseAvailability[] GetCruiseAvailabilities(Guid CruiseGuid) {
            if (CruiseGuid != null) {
                Cruise? c = _bll.GetCruise(CruiseGuid);
                if (c != null) {
                    return _bll.GetCruiseAvailabilities(c);
                }
            }

            // Aucun résultat
            return new List<CruiseAvailability>().ToArray();
        }

        [HttpGet("Cabin/{CabinId}")]
        public Cabin? GetCabin(Guid CabinId) {
            var car = _bll.GetCabin(CabinId);
            return car;
        }

        [HttpPost("Book")]
        public CruiseBooking Book(Guid CabinId, DateTime From, DateTime To, Person rentedTo) {
            return _bll.Book(CabinId, From, To, rentedTo);
        }
    }
}