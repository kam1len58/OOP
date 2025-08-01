namespace WorkSix;

public abstract class Shape
{
    Location location;
    protected Shape(Location loc)
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
