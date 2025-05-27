namespace laba2;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    ~Person()
    {
        Name = "";
    }

    public override string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}
