namespace Shop;

class Product
{
    public int Code { get; }

    public string Name { get; }

    public Product(int code, string name)
    {
        Code = code;
        Name = name;
    }

    public override string ToString() => $"Товар-{Name}, код товара-{Code}";
}
