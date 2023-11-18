using FakeDataGenerator.models;

namespace FakeDataGenerator.creators;

public interface IPersonFactory
{
    IEnumerable<Person> CreatePersons();

    IEnumerable<Person> CreatePersonsWithAge();

    IEnumerable<Person> CreatePersonsFullInfo();
}