
namespace WorkShop;

public class Shop
{
    public int Code { get; }
    public string Name { get; }
    public string Address { get; }

    private readonly Dictionary<int, (Product Product, int Quanity, int Price)> _products = [];


    public IReadOnlyDictionary<int, (Product Product, int Quanity, int Price)> Products => _products;

    public Shop(int code, string name, string address, params (Product Product, int Quanity, int Price)[] products)
    {
        Code = code;
        Name = name;
        Address = address;
        foreach (var product in products)
        {
            _products[product.Product.Code] = product;
        }
    }

    public void AddBatchProducts(params (Product Product, int Quantity, int Price)[] products)
    {
        foreach (var product in products)
        {
            if (_products.TryGetValue(product.Product.Code, out (Product Product, int Quanity, int Price) value))
            {
                _products[product.Product.Code] = (product.Product, product.Quantity + value.Quanity, product.Price);
            }
            else
            {
                _products[product.Product.Code] = (product.Product, product.Quantity, product.Price);
            }
        }
    }
}
