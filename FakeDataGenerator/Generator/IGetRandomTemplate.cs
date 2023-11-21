namespace FakeDataGenerator.generator;

public interface IGetRandomTemplate<out T>
{
    public T GetRandomTemplate();
}