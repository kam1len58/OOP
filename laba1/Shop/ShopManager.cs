namespace WorkShop;

public class ShopsManager
{
    Shop? shop1;
    Shop? shop2;
    Shop? shop3;
    public Shop[]? shops;

    public List<(int ProductCode,Shop Shop, Product Product)> SearchProduct(Shop shop, int productCode)
    {
        List<(int ProductCode, Shop Shop, Product Product)> product = new();
        string? productName = GetProductByCode(shop, productCode);
        if (productName == null)
        {
            return product;
        }

        if(shop.productSet.TryGetValue(productCode, out var value))
        {
            if(productCode==value.Product.Code)
            {
                product.Add((value.Product.Code,shop,value.Product));
            }
        }
        return product;
    }

    public string? GetProductByCode(Shop shop, int productCode)
    {
        if(shop.productSet.TryGetValue(productCode, out var product))
        {
            if (productCode == product.Product.Code)
            {
                return product.Product.Name;
            }
        }
        return null;
    }

    public List<(Shop Shop, Product Product)> SearchCheapestShops(int productCode, Shop[] shops)
    {
        List<(Shop Shop, Product Product)> cheapestShops = new();
        int price = int.MaxValue;
        foreach (var shop in shops)
        {
            var concreteProduct = SearchProduct(shop, productCode);
            foreach (var item in concreteProduct)
            {
                if (shop.productSet.TryGetValue(item.ProductCode, out var product))
                {
                    if (product.Price < price)
                    {
                        cheapestShops.Clear();
                        price = product.Price;
                        cheapestShops.Add((shop, product.Product));
                    }
                    else if (product.Price == price)
                    {
                        cheapestShops.Add((shop, product.Product));
                    }
                }
            }
        }
        return cheapestShops;
    }
}
