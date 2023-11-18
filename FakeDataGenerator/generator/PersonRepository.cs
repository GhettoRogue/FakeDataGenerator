using FakeDataGenerator.creators;
using FakeDataGenerator.models;

namespace FakeDataGenerator.generator;

public class PersonRepository
{
    private readonly IPersonFactory _personFactory;

    public PersonRepository(IPersonFactory personFactory)
    {
        _personFactory = personFactory;
        
    }
    
    public IEnumerable<Person> GetPersons() => _personFactory.CreatePersons();
    
    public IEnumerable<Person> GetPersonsWithAge() => _personFactory.CreatePersonsWithAge();
    
    public IEnumerable<Person> GetPersonsFullInfo() => _personFactory.CreatePersonsFullInfo();
}