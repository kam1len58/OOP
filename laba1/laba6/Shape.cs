namespace WorkSix;

public abstract class Shape
{
    public readonly Location location;

    public Shape(Location loc)
    {
        location = loc;
    }

    public override string ToString()
    {
        return location.ToString();
    }

    abstract public double Area();

    abstract public double Perimeter();
}
