namespace laba2;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        //Cпособ 1
        //for(int i = 0; i < people.Length; i++)
        //{
        //    string name = Console.ReadLine();
        //    people[i]=new Person(name);
        //}
        //foreach(var person in people)
        //{
        //    Console.WriteLine(person.ToString());
        //}

        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person{ Name = Console.ReadLine() };
        }

        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
