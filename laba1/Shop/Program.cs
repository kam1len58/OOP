namespace Shop;

class Program
{
    static void Main(string[] args)
    {
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");

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
    }
}
