
namespace WorkShop;

public class ShopsManager
{
    private List<Shop> _shops = new();

    public ShopsManager(List<Shop> shops)
    {
        _shops = shops;
    }

    public (HashSet<Shop> Shops, int TotalPriceBatch)? SearchTheCheapestBatch(Dictionary<int, int> batchOfProducts)
    {
        (HashSet<Shop> Shops, int TotalPriceBatch)? cheapestBatch = null;
        HashSet<Shop> shops = new();
        (Shop Shop, int TotalPriceBatch)? productsBatch = null;
        foreach (var shop in _shops)
        {
            var result = BuyBatchOfProducts(shop.Code, batchOfProducts);
            if (result == null)
                continue;
            if (productsBatch == null)
            {
                productsBatch = result;
            }
            if (result.Value.TotalPriceBatch < productsBatch.Value.TotalPriceBatch)
            {
                productsBatch = result;
                shops.Clear();
                shops.Add(shop);
            }
            else if (result.Value.TotalPriceBatch == productsBatch.Value.TotalPriceBatch)
            {
                shops.Add(shop);
            }
        }

        if (productsBatch != null)
        {
            cheapestBatch = (shops, productsBatch.Value.TotalPriceBatch);
        }
        return cheapestBatch;
    }

    public int GetProductPriceByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.Products)
        {
            if (productCode == item.Key)
            {
                return item.Value.Price;
            }
        }
        return 0;
    }

    public (Shop Shop, int TotalPriceBatch)? BuyBatchOfProducts(int shopCode, Dictionary<int, int> batchOfProducts)
    {
        (Shop Shop, int TotalPriceBatch)? totalBatchPrice = null;
        int totalPriceBatch = 0;
        foreach (var shop in _shops)
        {
            if (shop.Code == shopCode)
            {
                foreach (var product in shop.Products)
                {
                    if (batchOfProducts.TryGetValue(product.Key, out var Quantity))
                    {
                        if (product.Value.Quanity >= Quantity)
                        {
                            totalPriceBatch += GetProductPriceByCode(shop, product.Key) * Quantity;
                            totalBatchPrice = (shop, totalPriceBatch);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        return totalBatchPrice;
    }
}
