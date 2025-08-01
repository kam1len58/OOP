namespace WorkSix;

class Program
{
    static void Main(string[] args)
    {
        Location location = new(5, 6);
        Circle circle = new Circle(location, 6.7);
        Console.WriteLine($"Периметр круга:{circle.Perimeter()}\nПлощадь круга:{circle.Area()}\n");
        Rectangle rectangle = new Rectangle(location);
        Console.WriteLine($"Периметр прямоугольника:{rectangle.Perimeter()}\nПлощадь прямоугольника:{rectangle.Area()}");
    }
}

