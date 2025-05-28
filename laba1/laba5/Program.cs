namespace laba5;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            string? name = Console.ReadLine();
            people[i]=new Student(name!);
            if(i==2)
            {
                people[i]=new Teacher(name!);
            }
        }
    }
}
