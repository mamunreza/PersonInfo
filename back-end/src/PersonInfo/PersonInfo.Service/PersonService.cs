using System.Diagnostics;
using Microsoft.Extensions.Logging;
using PersonInfo.Data;
using Microsoft.EntityFrameworkCore;
using PersonInfo.Contract.Views;
using PersonInfo.Data.Model;

namespace PersonInfo.Service
{
    public interface IPersonService
    {
        Task<PersonView> GetByIdAsync(int id);
        Task<PersonView> CreateAsync(Person person);
        Task<PersonView> UpdateAsync(Person person);
    }

    public class PersonService : IPersonService
    {
        private readonly ILogger<PersonService> _logger;
        private readonly PersonInfoContext _personInfoContext;

        public PersonService(
            ILogger<PersonService> logger,
            PersonInfoContext personInfoContext)
        {
            ArgumentNullException.ThrowIfNull(logger);
            ArgumentNullException.ThrowIfNull(personInfoContext);

            _logger = logger;
            _personInfoContext = personInfoContext;
        }

        public async Task<PersonView> GetByIdAsync(int id)
        {
            var person = await _personInfoContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
            if (person != null)
            {
                return person.ToPersonView();
            }

            _logger.LogInformation($"Person not found for id: {id}");
            return null;
        }

        public async Task<PersonView> CreateAsync(Person person)
        {
            var newPerson = _personInfoContext.Persons.Add(person);
            await _personInfoContext.SaveChangesAsync();
            return newPerson.Entity.ToPersonView();
        }

        public async Task<PersonView> UpdateAsync(Person person)
        {
            var entity =
                await _personInfoContext.Persons.FirstOrDefaultAsync(x => x.Id == person.Id);
            if (entity != null)
            {
                entity.Name = person.Name;
                entity.SectorId = person.SectorId;
                entity.AgreeToTerms = person.AgreeToTerms;
            }
            await _personInfoContext.SaveChangesAsync();
            Debug.Assert(entity != null, nameof(entity) + " != null");
            return entity.ToPersonView();
        }
    }

}
