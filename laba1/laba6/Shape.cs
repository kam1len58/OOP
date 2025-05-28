namespace laba6;

abstract class Shape
{
    protected Location location = new Location();

    public override string ToString()
    {
        return location.ToString();
    }

    abstract public double Area();

    abstract public double Perimeter();
}
