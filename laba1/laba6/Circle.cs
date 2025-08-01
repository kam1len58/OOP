namespace WorkSix;
class Circle : Shape
{
    protected double radius;

    public Circle(Location loc,double radius):base(loc)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}
