using Microsoft.AspNetCore.Mvc;
using PersonInfo.Contract.Commands;
using PersonInfo.Contract.Views;
using PersonInfo.Service;

namespace PersonInfo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(
            ILogger<PersonController> logger, 
            IPersonService personService)
        {
            ArgumentNullException.ThrowIfNull(logger);
            ArgumentNullException.ThrowIfNull(personService);

            _logger = logger;
            _personService = personService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            _logger.LogInformation("Get person information");
            var personView = await _personService.GetByIdAsync(id);
            return Ok(personView);
        }

        [HttpPost]
        public async Task<PersonView> CreateAsync([FromBody] CreatePersonCommand newPerson)
        {
            _logger.LogInformation("Create person information");
            try
            {
                var createdPerson = await _personService.CreateAsync(newPerson.ToPerson());

                if (createdPerson == null)
                {
                    return DefaultView();
                }
                return createdPerson;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return DefaultView();
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditAsync([FromBody] UpdatePersonCommand updatedPersonCommand)
        {
            try
            {
                _logger.LogInformation("Edit person information");
                var updatedPerson =
                    await _personService.UpdateAsync(updatedPersonCommand.ToPerson());
                return Ok(updatedPerson);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return Problem("The action was not successful. Please check logs.");
            }
        }

        private static PersonView DefaultView()
        {
            var view = new PersonView
            {
                ErrorMessage = "Unsuccessful",
                Success = false
            };
            return view;
        }
    }
}
