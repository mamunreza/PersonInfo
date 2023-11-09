using PersonInfo.Contract.Commands;
using PersonInfo.Contract.Views;
using PersonInfo.Data.Model;

namespace PersonInfo.Service
{
    public static class MapperExtension
    {
        public static Sector ToSector(this SectorView view)
        {
            return new Sector
            {
                Id = view.Id,
                Name = view.Name,
                ParentId = view.ParentId
            };
        }

        public static List<Sector> ToSectors(this List<SectorView> views)
        {
            return views.Select(sectorView => new Sector
            {
                Id = sectorView.Id,
                Name = sectorView.Name,
                ParentId = sectorView.ParentId
            })
                .ToList();
        }

        public static SectorView ToSectorView(this Sector sector)
        {
            return new SectorView
            {
                Id = sector.Id,
                Name = sector.Name,
                ParentId = sector.ParentId
            };
        }

        public static List<SectorView> ToSectorViews(this List<Sector> sectors)
        {
            return sectors.Select(sectorView => new SectorView
            {
                Id = sectorView.Id,
                Name = sectorView.Name,
                ParentId = sectorView.ParentId,
                IsParent = sectorView.Children.Any() && sectorView.Id != sectorView.ParentId,
                Level = sectorView.Id % 10
            })
                .ToList();
        }


        public static Person ToPerson(this CreatePersonCommand createPersonCommand)
        {
            return new Person
            {
                Name = createPersonCommand.Name,
                SectorId = createPersonCommand.SectorId,
                AgreeToTerms = createPersonCommand.AgreeToTerms
            };
        }
        public static Person ToPerson(this UpdatePersonCommand updatedPersonCommand)
        {
            return new Person
            {
                Id = updatedPersonCommand.Id,
                Name = updatedPersonCommand.Name,
                SectorId = updatedPersonCommand.SectorId,
                AgreeToTerms = updatedPersonCommand.AgreeToTerms
            };
        }

        public static PersonView ToPersonView(this Person person)
        {
            if (person == null)
            {
                return new PersonView
                {
                    Success = false,
                    ErrorMessage = "Person info create unsuccessful"
                };
            }

            return new PersonView
            {
                Id = person.Id,
                Name = person.Name,
                SectorId = person.SectorId,
                AgreeToTerms = person.AgreeToTerms,
                Success = true
            };
        }

        public static List<PersonView> ToPersonViews(this List<Person> persons)
        {
            return persons.Select(personView => new PersonView
            {
                Id = personView.Id,
                Name = personView.Name,
                SectorId = personView.SectorId,
                AgreeToTerms = personView.AgreeToTerms
            })
                .ToList();
        }
    }
}
