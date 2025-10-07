
namespace WorkShop;

public class ShopsManager
{
    private List<Shop> _shops = [];

    public ShopsManager(List<Shop> shops)
    {
        _shops = shops;
    }

    public (HashSet<Shop> Shop, Product Product)? SearchCheapestShops(int productCode)
    {
        (HashSet<Shop> Shop, Product Product)? cheapestShops = null;
        var productsByCode = SearchProductByCodeInShops(productCode);
        bool isProductInStock = true;
        HashSet<Shop> shops = [];
        if (productsByCode.Count == 0)
        {
            isProductInStock=false;
            return cheapestShops;
        }

        if (isProductInStock)
        {
            int minProductPrice = productsByCode.First().ProductPrice;
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
        }

        return cheapestShops;
    }

    private List<(Shop Shop, Product Product, int ProductPrice)> SearchProductByCodeInShops(int productCode)
    {
        List<(Shop Shop, Product Product, int ProductPrice)> products = [];
        foreach (var shop in _shops)
        {
            if (shop.Products.TryGetValue(productCode, out var product))
            {
                products.Add((shop, product.Product, product.Price));
            }
        }
        return products;
    }
}
