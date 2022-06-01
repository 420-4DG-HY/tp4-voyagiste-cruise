using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using CruiseDTO;

using CommonDataDTO;

namespace CruiseDAL
{
    public interface ICruiseDataAccess
    {
        
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
    }
}
