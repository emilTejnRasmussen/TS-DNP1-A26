namespace Ex3;

public class Person(string name)
{
    private string Name { get; } = name;

    public void Introduce()
    {
        Console.WriteLine($"Hi, i am {Name}");
    }
}