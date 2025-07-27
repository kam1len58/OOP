namespace WorkShop;

class Program
{
    static void Main(string[] args)
    {
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopsManager = new ShopsManager();
        shopsManager.shops = [shop1, shop2 , shop3];

        shop1.DeliveryBatchProducts
        (
            (new Product(1, "ХЛЕБ"), 80, 45),
            (new Product(2, "МОЛОКО"), 30, 85),
            (new Product(3, "РИС"), 40, 120),
            (new Product(4, "МАСЛО"), 25, 150),
            (new Product(5, "МЯСО"), 15, 400),
            (new Product(6, "РЫБА"), 20, 300),
            (new Product(7, "ЯЙЦА"), 100, 90),
            (new Product(8, "САХАР"), 60, 60),
            (new Product(9, "СОЛЬ"), 50, 30),
            (new Product(10, "КАРТОФЕЛЬ"), 200, 25)
        );
        int budget = 1000;
        var result = shopsManager.GetProductsWithInBudget(budget, shopsManager.shops);
        foreach (var product in result)
        {
            Console.WriteLine($"На {budget} рублей вы можете купить {product.NumberOfProducts} шт. {product.Product.Name} в магазине {product.Shop.Name}\n");
        }
    }
}
