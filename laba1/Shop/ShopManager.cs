namespace WorkShop;

public class ShopManager
{
    Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
    Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
    Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
    Dictionary<int, (Shop Shop, string ProductName)> SearchProduct(Shop shop, int productCode)
    {
        Dictionary<int, (Shop Shop, string ProductName)> product = new();
        string? productName = GetProductByCode(shop, productCode);
        if (productName == null)
        {
            Console.WriteLine("Такого продукта не существует");
            return product;
        }

        foreach(var item in shop.productSet)
        {
            if(item.Value.Product.Name == productName)
            {
                product.Add(item.Value.Price,(shop, item.Value.Product.Name));
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

    public List<(Shop Shop, string ProductName)> SearchCheapestProduct(Shop shop1, Shop shop2, Shop shop3, int productCode)
    {
        Dictionary<int, (Shop Shop, string ProductName)> cheapProduct1 = SearchProduct(shop1, productCode);
        Dictionary<int, (Shop Shop, string ProductName)> cheapProduct2 = SearchProduct(shop2, productCode);
        Dictionary<int, (Shop Shop, string ProductName)> cheapProduct3 = SearchProduct(shop3, productCode);
        List<(Shop Shop, string ProductName)> shops = new();

        int cheapestProductPrice = Math.Min(cheapProduct1.Keys.First(), Math.Min(cheapProduct2.Keys.First(), cheapProduct3.Keys.First()));
        
        if(cheapestProductPrice == 0)
        {
            Console.WriteLine("Такого товара не существует");
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct1.Keys.First() && cheapestProductPrice == cheapProduct2.Keys.First() && cheapestProductPrice == cheapProduct3.Keys.First())
        {
            shops.Add((shop1, cheapProduct1.Values.First().ProductName));
            shops.Add((shop2, cheapProduct2.Values.First().ProductName));
            shops.Add((shop3, cheapProduct3.Values.First().ProductName));
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct1.Keys.First() && cheapestProductPrice == cheapProduct3.Keys.First())
        {
            shops.Add((shop1, cheapProduct1.Values.First().ProductName));
            shops.Add((shop3, cheapProduct3.Values.First().ProductName));
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct1.Keys.First() && cheapestProductPrice == cheapProduct2.Keys.First())
        {
            shops.Add((shop1, cheapProduct1.Values.First().ProductName));
            shops.Add((shop2, cheapProduct2.Values.First().ProductName));
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct2.Keys.First() && cheapestProductPrice == cheapProduct3.Keys.First())
        {
            shops.Add((shop2, cheapProduct2.Values.First().ProductName));
            shops.Add((shop3, cheapProduct3.Values.First().ProductName));
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct1.Keys.First())
        {
            shops.Add((shop1, cheapProduct1.Values.First().ProductName));
            return shops;
        }
        else if (cheapestProductPrice == cheapProduct2.Keys.First())
        {
            shops.Add((shop2, cheapProduct1.Values.First().ProductName));
            return shops;
        }
        else
        {
            shops.Add((shop3, cheapProduct3.Values.First().ProductName));
            return shops;
        }
    }
}
