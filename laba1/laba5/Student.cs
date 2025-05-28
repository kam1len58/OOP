namespace laba5;

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Study");
    }

    public Student(string name):base(name)
    {
        
    }
}
