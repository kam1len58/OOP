namespace WorkShop;

public class Shop
{
    private Dictionary<int, (Product Product, int Quanity, int Price)> _productSet = new();
    public int Code { get; }
    public string Name { get; }
    public string Address { get; }

    public Dictionary<int, (Product Product, int Quanity, int Price)> Products
    {
        get { return _productSet; }
    }

    public Shop(int code, string name, string address, params (Product Product, int Quanity, int Price)[] products)
    {
        Code = code;
        Name = name;
        Address = address;
        foreach (var product in products)
        {
            _productSet[product.Product.Code] = product;
        }
    }

    public void DeliveryBatchProducts(params (Product Product, int Quanity, int Price)[] products)
    {
        foreach (var product in products)
        {
            if (_productSet.TryGetValue(product.Product.Code, out (Product Product, int Quanity, int Price) value))
            {
                _productSet[product.Product.Code] = (product.Product, product.Quanity + value.Quanity, product.Price);
            }
            else
            {
                _productSet[product.Product.Code] = (product.Product, product.Quanity, product.Price);
            }
        }
    }
}
