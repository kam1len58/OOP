namespace WorkShop;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20",
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
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50",
          (new Product(1, "ХЛЕБ"), 35, 40),
          (new Product(2, "МОЛОКО"), 25, 95),
          (new Product(3, "РИС"), 30, 100),
          (new Product(4, "МАСЛО"), 35, 120),
          (new Product(5, "МЯСО"), 25, 550),
          (new Product(6, "РЫБА"), 40, 400),
          (new Product(7, "ЯЙЦА"), 50, 140),
          (new Product(8, "САХАР"), 80, 90),
          (new Product(9, "СОЛЬ"), 30, 20),
          (new Product(10, "КАРТОФЕЛЬ"), 170, 45)
        );
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40",
            (new Product(1, "ХЛЕБ"), 60, 50),
            (new Product(2, "МОЛОКО"), 40, 95),
            (new Product(3, "РИС"), 50, 90),
            (new Product(4, "МАСЛО"), 60, 130),
            (new Product(5, "МЯСО"), 40, 550),
            (new Product(6, "РЫБА"), 60, 470),
            (new Product(7, "ЯЙЦА"), 40, 100),
            (new Product(8, "САХАР"), 100, 20),
            (new Product(9, "СОЛЬ"), 40, 35),
            (new Product(10, "КАРТОФЕЛЬ"), 240, 55)
        );
        ShopsManager shopsManager = new ShopsManager(new() { { 1, shop1 }, { 2, shop2 }, { 3, shop3 } });
        int budget = 1000;
        var result = shopsManager.GetProductsWithInBudget(budget, 2);
        if (result.Count != 0)
        {
            foreach (var product in result)
            {
                logger.WtiteLog($"{DateTime.Now} На {budget} рублей вы можете купить {product.NumberOfProducts} шт. {product.Product.Name} в магазине {product.Shop.Name}\n");
            }
        }
        else
        {
            logger.WtiteLog($"{DateTime.Now} Товары отсутствуют или у вас недостаточно денег");
        }
    }
}
