namespace WorkShop;
using System.Linq;

public class ShopsManager
{
    private List<Shop> _shops = new();

    public ShopsManager(List<Shop> shops)
    {
        _shops = shops;
    }

    public (List<Shop> Shop, Product Product)? SearchCheapestShops(int productCode)
    {
        (List<Shop> Shop, Product Product) cheapestShops = new();
        var productsByCode = SearchProductByCodeInShops(productCode);
        if (productsByCode.Count == 0)
            return null;

        int minProductPrice = productsByCode.First().ProductPrice;
        List<Shop> shops = new();
        foreach (var product in productsByCode)
        {
            if (product.ProductPrice < minProductPrice)
            {
                minProductPrice = product.ProductPrice;
                shops.Clear();
                shops.Add(product.Shop);
            }
            else if (product.ProductPrice == minProductPrice)
            {
                shops.Add(product.Shop);
            }
        }
        cheapestShops = (shops, productsByCode.First().Product);
        
        return cheapestShops;
    }

    private List<(Shop Shop, Product Product, int ProductPrice)> SearchProductByCodeInShops(int productCode)
    {
        List<(Shop Shop, Product Product, int ProductPrice)> products = new();
        foreach (var shop in _shops)
        {
            if (shop.Products.TryGetValue(productCode, out var product))
                products.Add((shop, product.Product, product.Price));
        }
        return products;
    }
}
