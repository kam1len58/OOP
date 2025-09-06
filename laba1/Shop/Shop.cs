namespace WorkShop;

public class Shop
{
    public int Code { get; }
    public string Name { get; }
    public string Address { get; }
    public Dictionary<int, (Product Product, int Quanity, int Price)> ProductSet
    {
        get { return productSet; }
        set { productSet = value; }
    }

    public Shop(int code, string name, string address, params (Product Product, int Quanity, int Price)[] products)
    {
        Code = code;
        Name = name;
        Address = address;
        foreach (var product in products)
        {
            productSet[product.Product.Code] = product;
        }
    }

    private Dictionary<int, (Product Product, int Quanity, int Price)> productSet = new();

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

    public List<(Product Product, int NumberOfProducts)> SearchProductByBudget(Shop shop, int budget)
    {
        List<(Product Product, int NumberOfProducts)> products = [];
        foreach (var item in shop.ProductSet)
        {
            if (budget >= item.Value.Price)
            {
                int numberOfProducts = budget / item.Value.Price;
                products.Add((item.Value.Product, numberOfProducts));
            }
        }
        return products;
    }
}
