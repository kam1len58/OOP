namespace WorkEight;

class Program
{
    static void Main(string[] args)
    {
        Dog dog;
        string? name;
        do
        {
            name = Console.ReadLine()!;
            dog = new Dog { Name = name };
            Console.Clear();
        }
        while (name == null || name.Length == 0);
        Console.WriteLine(dog.Name);
        dog.Eat();
    }
}
