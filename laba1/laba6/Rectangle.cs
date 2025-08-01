namespace WorkSix;

class Rectangle : Shape
{
    protected double Width;
    protected double Height;
    public Rectangle(Location location) : base(location)
    {
        Width = location.X;
        Height = location.Y;
    }
    public override double Area()
    {
        return Width * Height;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
