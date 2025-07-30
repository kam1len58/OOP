namespace WorkShop;

public class Shop
{
    public int Code { get; }
    public string Name { get; }
    public string Address { get; }

    public Shop(int code, string name, string address)
    {
        Code = code;
        Name = name;
        Address = address;
    }

    public Dictionary<int, (Product Product, int Quanity, int Price)> productSet = new();

    public void DeliveryBatchProducts(params (Product Product, int Quanity, int Price)[] products)
    {
        foreach (var product in products)
        {
            if (productSet.TryGetValue(product.Product.Code, out (Product Product, int Quanity, int Price) value))
            {
                productSet[product.Product.Code] = (product.Product, product.Quanity + value.Quanity, product.Price);
            }
            else
            {
                productSet[product.Product.Code] = (product.Product, product.Quanity, product.Price);
            }
        }
    }
}
