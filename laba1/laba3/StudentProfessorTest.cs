namespace laba3;

class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.Greet();
        student.SetAge(21);
        student.Study();

        Teacher teacher = new Teacher();
        teacher.Greet();
        teacher.SetAge(45);
        teacher.Explain();
    }
}
