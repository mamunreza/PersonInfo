using Microsoft.AspNetCore.Mvc;
using PersonInfo.Service;

namespace PersonInfo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SectorController : ControllerBase
    {
        private readonly ILogger<SectorController> _logger;
        private readonly ISectorService _sectorService;
        public SectorController(
            ILogger<SectorController> logger, 
            ISectorService sectorService)
        {
            ArgumentNullException.ThrowIfNull(logger);
            ArgumentNullException.ThrowIfNull(sectorService);

            _logger = logger;
            _sectorService = sectorService;
        }
        
        [HttpGet]
        public async Task<IActionResult> AllAsync()
        {
            _logger.LogInformation("Get all sectors");

            try
            {
                var sectors = await _sectorService.GetAllInstancesAsync();

                if (sectors == null || sectors.Count == 0)
                {
                    _logger.LogError("Could not get sectors information");
                    return NoContent();
                }

                return Ok(sectors);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                return NoContent();
            }
        }
    }
}
