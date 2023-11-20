using FakeDataGenerator.models;

namespace FakeDataGenerator.generator;

public interface IGetRandomData
{
    string GetRandomFirstName();

    string GetRandomLastName();

    string GetRandomPatronymic();

    int GetRandomAge();

    string GetRandomPhoneNumber();

    Person GetRandomTemplatePerson(); // have to add interface that returns  <out T>
}