namespace laba1;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            people[i]=new Person();
            people[i].Name=Console.ReadLine();
        }   
        foreach(var person in people)
        {
            Console.WriteLine(person.ToString());
        }
    }  
}
