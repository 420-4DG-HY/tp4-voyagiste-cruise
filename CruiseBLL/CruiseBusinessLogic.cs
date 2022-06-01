using CommonDataDTO;
using CruiseDTO;
using CruiseDAL;

using Microsoft.Extensions.Logging;

namespace CruiseBLL
{
    public interface ICruiseBusinessLogic
    {

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
    }
}