namespace WorkOne;

class PersonWithInit
{
    public required string Name { get; init; }

    public override string ToString() => $"Hello! My name is {Name}";
}
