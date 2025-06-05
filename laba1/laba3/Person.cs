namespace Laba3;

class Person
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public required int SetAge { get; init; }
}
