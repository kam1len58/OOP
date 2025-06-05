namespace laba2;

public class Person
{
    public required string Name { get; set; }

    //СПОСОБ 1
    //public Person(string name)
    //{
    //    Name = name;
    //}
    ~Person()
    {
        Name = "";
    }

    public override string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}
