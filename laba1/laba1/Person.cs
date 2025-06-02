namespace Laba1;

public class Person
{
    private string? name;
    public string Name
    {
        get
        {
            return name!;
        }
        set
        {
            name = value;
        }
    }
    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}


