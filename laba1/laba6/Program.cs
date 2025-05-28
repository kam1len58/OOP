namespace laba6;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(6.7);
        Console.WriteLine($"Периметр круга:{circle.Perimeter()}\nПлощадь круга:{circle.Area()}\n");
        Rectangle rectangle = new Rectangle(7.4, 9.2);
        Console.WriteLine($"Периметр прямоугольника:{rectangle.Perimeter()}\nПлощадь прямоугольника:{rectangle.Area()}");
    }
}

