namespace WorkTwo;

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

        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }

        PersonWithPrivateSet[] persons = new PersonWithPrivateSet[3];
        for (int i = 0; i < persons.Length; i++)
        {
            string? name;
            do
            {
                name = Console.ReadLine();
            }
            while (name == null || name.Length == 0);
            persons[i] = new PersonWithPrivateSet(name);
        }

        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
