namespace Laba1;

class Program
{
    static void Main(string[] args)
    {

        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            string? name;
            do
            {
                name = Console.ReadLine();
            }
            while (name == null || name.Length == 0);
            people[i] = new Person(name);
        }
        foreach (var person1 in people)
        {
            Console.WriteLine(person1.ToString());
        }

        Person2[] person2s = new Person2[3];
        for (int i = 0; i < person2s.Length; i++)
        {
            string? name;
            do
            {
                name = Console.ReadLine();
            }
            while (name == null || name.Length == 0);
            person2s[i] = new Person2 { Name = name };
        }

        foreach (var person in person2s)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
