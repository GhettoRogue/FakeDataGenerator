namespace FakeDataGenerator.generator;

public interface IGetRandomData
{
    string GetRandomFirstName();

    string GetRandomLastName();

    string GetRandomPatronymic();

    int GetRandomAge();

    string GetRandomPhoneNumber();
}