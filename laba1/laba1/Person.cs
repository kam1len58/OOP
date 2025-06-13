namespace Laba1;

public class Person
{
    public required string Name { get; init; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString() => $"Hello! My name is {Name}";
}


