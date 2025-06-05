namespace Laba1;

public class Person
{
    public required string? Name { get; set; }

    //public Person(string name)
    //{
    //    Name = name;
    //}

    public override string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}


