namespace Shop;

class Program
{
    static void Main(string[] args)
    {
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopManager shopManager = new ShopManager();

        shop1.DeliveryOfGoods(new Product(1, "ХЛЕБ"), 80, 45);
        shop1.DeliveryOfGoods(new Product(2, "МОЛОКО"), 30, 85);
        shop1.DeliveryOfGoods(new Product(3, "РИС"), 40, 120);
        shop1.DeliveryOfGoods(new Product(4, "МАСЛО"), 25, 150);
        shop1.DeliveryOfGoods(new Product(5, "МЯСО"), 15, 400);
        shop1.DeliveryOfGoods(new Product(6, "РЫБА"), 20, 300);
        shop1.DeliveryOfGoods(new Product(7, "ЯЙЦА"), 100, 90);
        shop1.DeliveryOfGoods(new Product(8, "САХАР"), 60, 60);
        shop1.DeliveryOfGoods(new Product(9, "СОЛЬ"), 50, 30);
        shop1.DeliveryOfGoods(new Product(10, "КАРТОФЕЛЬ"), 200, 25);

        shop2.DeliveryOfGoods(new Product(1, "ХЛЕБ"), 35, 40);
        shop2.DeliveryOfGoods(new Product(2, "МОЛОКО"), 25, 95);
        shop2.DeliveryOfGoods(new Product(3, "РИС"), 30, 100);
        shop2.DeliveryOfGoods(new Product(4, "МАСЛО"), 35, 120);
        shop2.DeliveryOfGoods(new Product(5, "МЯСО"), 25, 550);
        shop2.DeliveryOfGoods(new Product(6, "РЫБА"), 40, 400);
        shop2.DeliveryOfGoods(new Product(7, "ЯЙЦА"), 50, 140);
        shop2.DeliveryOfGoods(new Product(8, "САХАР"), 80, 90);
        shop2.DeliveryOfGoods(new Product(9, "СОЛЬ"), 30, 20);
        shop2.DeliveryOfGoods(new Product(10, "КАРТОФЕЛЬ"), 170, 45);

        shop3.DeliveryOfGoods(new Product(1, "ХЛЕБ"), 60, 50);
        shop3.DeliveryOfGoods(new Product(2, "МОЛОКО"), 40, 95);
        shop3.DeliveryOfGoods(new Product(3, "РИС"), 50, 90);
        shop3.DeliveryOfGoods(new Product(4, "МАСЛО"), 60, 130);
        shop3.DeliveryOfGoods(new Product(5, "МЯСО"), 40, 550);
        shop3.DeliveryOfGoods(new Product(6, "РЫБА"), 60, 470);
        shop3.DeliveryOfGoods(new Product(7, "ЯЙЦА"), 40, 100);
        shop3.DeliveryOfGoods(new Product(8, "САХАР"), 100, 20);
        shop3.DeliveryOfGoods(new Product(9, "СОЛЬ"), 40, 35);
        shop3.DeliveryOfGoods(new Product(10, "КАРТОФЕЛЬ"), 240, 55);

        List<(int ProductCode, int Quanity)> batchOfProducts = new() { (1, 10), (2, 10), (3, 10) };
        var cheapestBratch = shopManager.SearchTheCheapestBatch(shop1, shop2, shop3, batchOfProducts);
        foreach(var cart in cheapestBratch)
        {
            Console.WriteLine($"Самый дешевая партия товаров в магазине {cart.Shop.Name} её стоимость {cart.TotalPriceBatch} рублей");
        }
    }
}
