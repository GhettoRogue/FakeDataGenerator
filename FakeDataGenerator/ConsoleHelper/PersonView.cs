using FakeDataGenerator.models;

namespace FakeDataGenerator.ConsoleHelper;

public static class PersonView
{
    
    public static void PrintPerson(IEnumerable<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Patronymic} {person.Age} {person.PhoneNumber}"); 
        }
    }
    
    public static void PrintPersonWithAge(IEnumerable<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Patronymic} {person.Age}"); 
        }
    }
    
    public static void PrintPersonWithAgeAndName(IEnumerable<Person> persons)
    {
        foreach (var person in persons)
        {
            Console.WriteLine($"{person.FirstName} {person.Age}"); 
        }
    }
}