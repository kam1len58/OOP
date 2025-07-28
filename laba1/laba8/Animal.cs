namespace WorkEight;

abstract class Animal
{
    public required string Name { get; init; }

    public abstract void Eat();
}
