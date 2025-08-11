namespace WorkShop;

public class Product
{
    public int Code { get; }

    public string Name { get; }

    public Product(int code, string name)
    {
        Code = code;
        Name = name;
    }

    public override string ToString() => $"Product-{Name}, Product code-{Code}";
}
