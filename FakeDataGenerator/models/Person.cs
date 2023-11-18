namespace FakeDataGenerator.models;

public class Person
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Patronymic { get; set; }

    public int Age { get; set; }

    public string? PhoneNumber { get; set; }

    public Person(string firstName, string lastName, string patronymic)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
    }

    public Person(string firstName, string lastName, string patronymic, int age)
        : this(firstName, lastName, patronymic)
    {
        Age = age;
    }

    public Person(string? firstName, string? lastName, string? patronymic, int age, string? phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic;
        Age = age;
        PhoneNumber = phoneNumber;
    }
}