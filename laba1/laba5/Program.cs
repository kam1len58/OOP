namespace laba5;

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
                if (name == null || name.Length == 0)
                {
                    Console.Clear();
                }
            }
            while (name == null || name.Length == 0);

            people[i] = new Teacher(name);

            if (i >= 1)
            {
                people[i] = new Student(name);
            }
        }

        foreach (var person in people)
        {
            if (person is Teacher teacher)
            {
                teacher.Explain();
            }
            else if (person is Student student)
            {
                student.Study();
            }
        }

    }
}
