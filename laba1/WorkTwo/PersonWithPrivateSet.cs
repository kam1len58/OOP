namespace WorkTwo;

public class PersonWithPrivateSet
{
    public string Name { get; private set; }
    public PersonWithPrivateSet(string name)
    {
        Name = name;
    }

    ~PersonWithPrivateSet()
    {
        Name = "";
    }

    public override string ToString() => $"Hello! My name is {Name}";
}
