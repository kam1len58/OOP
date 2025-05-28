namespace laba8;

abstract class Animal
{
    public string? Name { get; set; }

    public string SetName(string name)
    {
        Name = name;
        return Name;
    }

    public string? GetName()
    {
        return Name;
    }

    public abstract void Eat();
}
