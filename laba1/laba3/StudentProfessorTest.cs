namespace Laba3;

class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Person person = new Person { SetAge = 0 };
        person.Greet();

        Student student = new Student { SetAge = 21 };
        person.Greet();
        student.ShowAge();
        student.Study();

        Teacher teacher = new Teacher { SetAge = 45 };
        teacher.Greet();
        teacher.Explain();
    }
}
