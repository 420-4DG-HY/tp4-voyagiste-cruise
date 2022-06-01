using Microsoft.AspNetCore.Mvc;

namespace CruiseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CruiseController : ControllerBase
    {
        private readonly ILogger<CruiseController> _logger;

        public CruiseController(ILogger<CruiseController> logger)
        {
            _logger = logger;
        }
    }
}