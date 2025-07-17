namespace Shop;

class ShopManager
{
    public List<(Shop Shop, int TotalPriceBatch)> SearchTheCheapestBatch(Shop shop1, Shop shop2, Shop shop3, List<(int ProductCode, int Quanity)> batchOfProducts)
    {
        List<(Shop Shop, int TotalPriceBatch)> cheapestBatch = new();
        int shopBatchPrice1 = BuyBatchOfProducts(shop1, batchOfProducts);
        int shopBatchPrice2 = BuyBatchOfProducts(shop2, batchOfProducts);
        int shopBatchPrice3 = BuyBatchOfProducts(shop3, batchOfProducts);

        if (shopBatchPrice1 == int.MaxValue)
        {
            if (shopBatchPrice2 == int.MaxValue)
            {
                if (shopBatchPrice3 == int.MaxValue)
                {
                    Console.WriteLine("Покупка партии товаров невозможна из-за их нехватки");
                    return cheapestBatch;
                }
                else
                {
                    cheapestBatch.Add((shop3, shopBatchPrice3));
                    return cheapestBatch;
                }
            }
            else
            {
                var cheapestPriceBatch = Math.Min(shopBatchPrice2, shopBatchPrice3);
                if (cheapestPriceBatch == shopBatchPrice2)
                {
                    cheapestBatch.Add((shop2, shopBatchPrice2));
                }
                if (cheapestPriceBatch == shopBatchPrice3)
                {
                    cheapestBatch.Add((shop3, shopBatchPrice3));
                }
                return cheapestBatch;
            }
        }
        else
        {
            var cheapestPriceBatch = Math.Min(shopBatchPrice1,Math.Min(shopBatchPrice2,shopBatchPrice3));
            if (cheapestPriceBatch == shopBatchPrice1)
            {
                cheapestBatch.Add((shop1, shopBatchPrice1));
            }
            if (cheapestPriceBatch == shopBatchPrice2)
            {
                cheapestBatch.Add((shop2, shopBatchPrice2));
            }
            if (cheapestPriceBatch == shopBatchPrice3)
            {
                cheapestBatch.Add((shop3, shopBatchPrice3));
            }
            return cheapestBatch;
        }
                    
    }
    public int GetProductPriceByCode(Shop shop, int productCode)
    {
        foreach (var item in shop.productSet)
        {
            if (productCode == item.Product.Code)
            {
                return item.Price;
            }
        }
        return 0;
    }

    public int BuyBatchOfProducts(Shop shop, List<(int ProductCode, int Quanity)> batchOfProducts)
    {
        int totalPriceBatch = 0;
        foreach (var product in shop.productSet)
        {
            foreach (var item in batchOfProducts)
            {
                if (product.Product.Code == item.ProductCode)
                {
                    if (item.Quanity <= product.Quanity)
                    {
                        totalPriceBatch += GetProductPriceByCode(shop, item.ProductCode) * item.Quanity;
                    }
                    else
                    {
                        return totalPriceBatch=int.MaxValue;
                    }
                }
            }
        }
        if (totalPriceBatch == 0)
        {
            return totalPriceBatch=int.MaxValue;
        }
        return totalPriceBatch;
    }
}
