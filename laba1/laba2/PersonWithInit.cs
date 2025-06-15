namespace WorkTwo;

public class PersonWithInit
{
    public required string Name { get; init; }

    ~PersonWithInit()
    {

    }

    public override string ToString() => $"Hello! My name is {Name}";
}
