namespace FakeDataGenerator.generator;

public class DataGenerator
{
    private readonly IGetRandomData _getRandomData;

    public DataGenerator(IGetRandomData getRandomData)
    {
        _getRandomData = getRandomData;
    }

    public string GetFirstName() => _getRandomData.GetRandomFirstName();

    public string GetLastName() => _getRandomData.GetRandomLastName();

    public string GetPatronymic() => _getRandomData.GetRandomPatronymic();

    public int GetAge() => _getRandomData.GetRandomAge();

    public string GetPhoneNumber() => _getRandomData.GetRandomPhoneNumber();
}