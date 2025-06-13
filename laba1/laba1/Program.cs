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
            people[i] = new Person(name) { Name = name };
        }
        foreach (var person1 in people)
        {
            Console.WriteLine(person1.ToString());
        }


        Person[] people1 = new Person[3];
        for (int i = 0; i < people1.Length; i++)
        {
            people1[i] = new Person("") { Name = Console.ReadLine()! };
        }

        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
