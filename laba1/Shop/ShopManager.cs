namespace WorkShop;

public class ShopManager
{
    Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
    Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
    Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");

    public Dictionary<int, (Shop Shop, string ProductName)> SearchProduct(Shop shop, int productCode)
    {
        Dictionary<int, (Shop Shop, string ProductName)> product = new();
        string? productName = GetProductByCode(shop, productCode);
        if (productName == null)
        {
            return product;
        }

        foreach (var item in shop.productSet)
        {
            if (item.Value.Product.Code == productCode)
            {
                product.Add(item.Value.Product.Code, (shop, item.Value.Product.Name));
            }
        }
        return product;
    }

    string? GetProductByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.productSet)
        {
            if (productCode == item.Key)
            {
                return item.Value.Product.Name;
            }
        }
        return null;
    }

    public List<(Shop Shop, string ProductName)> SearchCheapestShops(int productCode, params Shop[] shops)
    {
        List<(Shop Shop, string ProductName)> cheapestShops = new();
        int price = int.MaxValue;
        foreach (var shop in shops)
        {
            var concreteProduct = SearchProduct(shop, productCode);
            foreach (var item in concreteProduct)
            {
                if (shop.productSet.TryGetValue(item.Key, out var product))
                {
                    if (product.Price < price)
                    {
                        cheapestShops.Clear();
                        price = product.Price;
                        cheapestShops.Add((shop, product.Product.Name));
                    }
                    else if (product.Price == price)
                    {
                        cheapestShops.Add((shop, product.Product.Name));
                    }
                }
            }
        }
        return cheapestShops;
    }
}
