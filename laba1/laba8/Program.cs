namespace laba8;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        string? name;
        do
        {
            name = Console.ReadLine();
            Console.Clear();
        }
        while (name == null || name.Length == 0);

        dog.Name = name;
        Console.WriteLine(dog.Name);
        dog.Eat();
    }
}
