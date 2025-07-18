namespace WorkThree;

class StudentProfessorTest
{
    public static void Test()
    {
        Person person = new Person { Age = 0 };
        person.Greet();

        Student student = new Student { Age = 21 };
        person.Greet();
        student.ShowAge();
        student.Study();

        Teacher teacher = new Teacher { Age = 45 };
        teacher.Greet();
        teacher.Explain();
    }
}
