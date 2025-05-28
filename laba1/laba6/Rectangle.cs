namespace laba6;

class Rectangle : Shape
{
    protected double Width;
    protected double Height;

    public Rectangle(double x, double y)
    {
        Width = x;
        Height = y;
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
