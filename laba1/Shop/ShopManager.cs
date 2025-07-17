using System.Collections.Generic;

namespace Shop;

class ShopManager
{
    public List<(Shop Shop, string ProductName)> SearchCheapestProduct(Shop shop1, Shop shop2, Shop shop3, int productCode)
    {
        int cheapProduct1 = int.MaxValue;
        int cheapProduct2 = int.MaxValue;
        int cheapProduct3 = int.MaxValue;

        foreach (var item in shop1.productSet)
        {
            if (productCode == item.Product.Code)
            {
                cheapProduct1 = item.Price;
            }
        }

        foreach (var item in shop2.productSet)
        {
            if (productCode == item.Product.Code)
            {
                cheapProduct2 = item.Price;
            }
        }

        foreach (var item in shop3.productSet)
        {
            if (productCode == item.Product.Code)
            {
                cheapProduct3 = item.Price;
            }
        }

        List<(Shop shop, string productName)> shops = new();
        string? productName = GetProductByCode(shop1, productCode) ?? GetProductByCode(shop2, productCode) ?? GetProductByCode(shop3, productCode);

        var cheapProductPrice = Math.Min(cheapProduct1, Math.Min(cheapProduct2, cheapProduct3));
        if (cheapProductPrice == int.MaxValue || productName==null)
        {
            Console.WriteLine("Такого товара не существует");
            return shops;
        }
        else if (cheapProductPrice == cheapProduct1 && cheapProductPrice == cheapProduct3 && cheapProductPrice == cheapProduct2)
        {
            shops.Add((shop1, productName));
            shops.Add((shop2, productName));
            shops.Add((shop3, productName));
            return shops;
        }
        else if (cheapProductPrice == cheapProduct1 && cheapProductPrice == cheapProduct3)
        {
            shops.Add((shop1, productName));
            shops.Add((shop3, productName));
            return shops;
        }
        else if (cheapProductPrice == cheapProduct1 && cheapProductPrice == cheapProduct2)
        {
            shops.Add((shop1, productName));
            shops.Add((shop2, productName));
            return shops;
        }
        else if (cheapProductPrice == cheapProduct2 && cheapProductPrice == cheapProduct3)
        {
            shops.Add((shop2, productName));
            shops.Add((shop3, productName));
            return shops;
        }
        else if (cheapProductPrice == cheapProduct1)
        {
            shops.Add((shop1, productName));
            return shops;
        }
        else if (cheapProductPrice == cheapProduct2)
        {
            shops.Add((shop2, productName));
            return shops;
        }
        else
        {
            shops.Add((shop3, productName));
            return shops;
        }

    }

    public string? GetProductByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.productSet)
        {
            if (productCode == item.Product.Code)
            {
                return item.Product.Name;
            }
        }
        return null;
    }
}
