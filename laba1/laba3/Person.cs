namespace WorkThree;

class Person
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public required int Age { get; init; }
}
