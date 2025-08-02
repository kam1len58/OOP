namespace WorkSix;

public class RectangleShape : Shape
{
    private double Width;
    private double Height;

    public RectangleShape(Location location) : base(location)
    {
        Width=location.X;
        Height=location.Y;
    }
    public override double Area()
    {
        return location.X * location.Y;
    }

    public override double Perimeter()
    {
        return 2 * (location.X + location.Y);
    }
}
