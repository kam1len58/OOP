namespace Shop;

class Program
{
    static void Main(string[] args)
    {

        Shop shop1 = new Shop(001, "Пятерочка", "Ул. Пушкина, 58");
        Shop shop2 = new Shop(002, "Магнит", "Пр. Мира, 13Б");
        Shop shop3 = new Shop(003, "Перекрёсток", "Ул. Ленина, 52");
        ShopManager shopManager = new ShopManager();

        List<(Product, int Quanity, int Price)> productSet1 = new();
        shop1.DeliveryOfGoods(productSet1, new Product(1, "ХЛЕБ"), 80, 45);
        shop1.DeliveryOfGoods(productSet1, new Product(2, "МОЛОКО"), 30, 85);
        shop1.DeliveryOfGoods(productSet1, new Product(3, "РИС"), 40, 120);
        shop1.DeliveryOfGoods(productSet1, new Product(4, "МАСЛО"), 25, 150);
        shop1.DeliveryOfGoods(productSet1, new Product(5, "МЯСО"), 15, 400);
        shop1.DeliveryOfGoods(productSet1, new Product(6, "РЫБА"), 20, 300);
        shop1.DeliveryOfGoods(productSet1, new Product(7, "ЯЙЦА"), 100, 90);
        shop1.DeliveryOfGoods(productSet1, new Product(8, "САХАР"), 60, 60);
        shop1.DeliveryOfGoods(productSet1, new Product(9, "СОЛЬ"), 50, 30);
        shop1.DeliveryOfGoods(productSet1, new Product(10, "КАРТОФЕЛЬ"), 200, 25);



        List<(Product, int, int)> productSet2 = new();
        shop2.DeliveryOfGoods(productSet2, new Product(1, "ХЛЕБ"), 35, 40);
        shop2.DeliveryOfGoods(productSet2, new Product(2, "МОЛОКО"), 25, 75);
        shop2.DeliveryOfGoods(productSet2, new Product(3, "РИС"), 30, 100);
        shop2.DeliveryOfGoods(productSet2, new Product(4, "МАСЛО"), 35, 120);
        shop2.DeliveryOfGoods(productSet2, new Product(5, "МЯСО"), 25, 460);
        shop2.DeliveryOfGoods(productSet2, new Product(6, "РЫБА"), 40, 400);
        shop2.DeliveryOfGoods(productSet2, new Product(7, "ЯЙЦА"), 50, 140);
        shop2.DeliveryOfGoods(productSet2, new Product(8, "САХАР"), 80, 90);
        shop2.DeliveryOfGoods(productSet2, new Product(9, "СОЛЬ"), 30, 20);
        shop2.DeliveryOfGoods(productSet2, new Product(10, "КАРТОФЕЛЬ"), 170, 45);

        List<(Product, int, int)> productSet3 = new();
        shop3.DeliveryOfGoods(productSet3, new Product(1, "ХЛЕБ"), 60, 50);
        shop3.DeliveryOfGoods(productSet3, new Product(2, "МОЛОКО"), 40, 95);
        shop3.DeliveryOfGoods(productSet3, new Product(3, "РИС"), 50, 140);
        shop3.DeliveryOfGoods(productSet3, new Product(4, "МАСЛО"), 60, 130);
        shop3.DeliveryOfGoods(productSet3, new Product(5, "МЯСО"), 40, 550);
        shop3.DeliveryOfGoods(productSet3, new Product(6, "РЫБА"), 60, 470);
        shop3.DeliveryOfGoods(productSet3, new Product(7, "ЯЙЦА"), 40, 100);
        shop3.DeliveryOfGoods(productSet3, new Product(8, "САХАР"), 100, 120);
        shop3.DeliveryOfGoods(productSet3, new Product(9, "СОЛЬ"), 40, 35);
        shop3.DeliveryOfGoods(productSet3, new Product(10, "КАРТОФЕЛЬ"), 240, 55);

        string cheapestProduct = "ХЛЕБ";
        shopManager.SearchCheapestProduct(shop1, shop2, shop3, productSet1, cheapestProduct, productSet2, productSet3);

        int budget = 1000;
        shopManager.GetProductsWithinBudget(productSet1, shop1, budget);

        (string Product, int Quanity)[] batchOfProducts = [("ХЛЕБ", 50), ("ЯЙЦА", 10), ("РИС", 20), ("МЯСО", 20), ("КАРТОФЕЛЬ", 15)];
        shopManager.BuyBatchOfProducts(batchOfProducts, productSet2);
        shopManager.SearchTheCheapestBatch(productSet1, productSet2, productSet3, shop1, shop2, shop3, batchOfProducts);
    }
}
