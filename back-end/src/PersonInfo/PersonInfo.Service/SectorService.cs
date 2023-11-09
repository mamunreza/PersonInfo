using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PersonInfo.Contract.Views;
using PersonInfo.Data;

namespace PersonInfo.Service
{
    public interface ISectorService
    {
        Task<List<SectorView>> GetAllInstancesAsync();
    }

    public class SectorService : ISectorService
    {
        private readonly ILogger<SectorService> _logger;
        private readonly PersonInfoContext _personInfoContext;

        public SectorService(
            ILogger<SectorService> logger,
            PersonInfoContext personInfoContext)
        {
            ArgumentNullException.ThrowIfNull(logger);
            ArgumentNullException.ThrowIfNull(personInfoContext);

            _logger = logger;
            _personInfoContext = personInfoContext;
        }

        public async Task<List<SectorView>>  GetAllInstancesAsync()
        {
            _logger.LogInformation("Get all sectors");
            var sectors = await _personInfoContext.Sectors.Include(x => x.Children)
                .ToListAsync();
            return sectors.ToSectorViews();
        }
    }
}