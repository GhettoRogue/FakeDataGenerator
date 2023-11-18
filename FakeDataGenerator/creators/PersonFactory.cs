using FakeDataGenerator.generator;
using FakeDataGenerator.models;

namespace FakeDataGenerator.creators;

public class PersonFactory : IPersonFactory
{
    private readonly DataGenerator? _randomData = new(new GetRandomData());
    
    private readonly int _count;

    public PersonFactory(int count)
    {
        _count = count; 
    }

    public IEnumerable<Person> CreatePersons()
    {
        var persons = new List<Person>();
        
        for (var i = 0; i < _count; i++)
        { 
            persons.Add(new Person(
                _randomData?.GetFirstName() ?? throw new InvalidOperationException(),
                _randomData?.GetLastName() ?? throw new InvalidOperationException(),
                _randomData?.GetPatronymic() ?? throw new InvalidOperationException()));
        }

        return persons;
    }

    public IEnumerable<Person> CreatePersonsWithAge()
    {
        var persons = new List<Person>();
        
        for (var i = 0; i < _count; i++)
        {
            persons.Add(new Person(
                _randomData?.GetFirstName() ?? throw new InvalidOperationException(),
                _randomData?.GetLastName() ?? throw new InvalidOperationException(),
                _randomData.GetPatronymic(),
                _randomData.GetAge()));
        }

        return persons;
    }

    public IEnumerable<Person> CreatePersonsFullInfo()
    {
        var persons = new List<Person>();
        
        for (var i = 0; i < _count; i++)
        {
            persons.Add(new Person(
                _randomData?.GetFirstName() ?? throw new InvalidOperationException(),
                _randomData?.GetLastName() ?? throw new InvalidOperationException(),
                _randomData?.GetPatronymic() ?? throw new InvalidOperationException(),
                _randomData.GetAge(),
                _randomData.GetPhoneNumber()));
        }

        return persons;
    }
}