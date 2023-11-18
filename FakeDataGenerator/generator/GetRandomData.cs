namespace FakeDataGenerator.generator;

public class GetRandomData : IGetRandomData
{
    private readonly Random _random = new();

    public string GetRandomFirstName()
    {
        string[] firstNames = { "John", "Mike", "Sarah", "Kate", "Adam", "Anna" };

        var index = _random.Next(firstNames.Length);

        return firstNames[index];
    }

    public string GetRandomLastName()
    {
        string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia" };

        var index = _random.Next(lastNames.Length);

        return lastNames[index];
    }

    public string GetRandomPatronymic()
    {
        string[] patronymic = { "James", "Marie", "Ann", "Lee", "John", "Rose" };

        var index = _random.Next(patronymic.Length);

        return patronymic[index];
    }

    public int GetRandomAge()
    {
        return _random.Next(18, 75);
    }

    public string GetRandomPhoneNumber()
    {
        return "+" + _random.Next(100, 999) + "-" + _random.Next(100, 999) + "-" + _random.Next(1000, 9999);
    }
}