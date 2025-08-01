namespace WorkSix;

public abstract class Shape
{
    Location location;
    protected Shape()
    {
        location=new Location();
    }

    public override string ToString()
    {
        return location.ToString();
    }

    abstract public double Area();

    abstract public double Perimeter();
}
