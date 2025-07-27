namespace TestProductsWithInBudget;

using System.Text.Json;
using WorkShop;


[TestClass]
public class TestProductsWithInBudget
{
    [TestMethod]
    public void GetProductsWithInBudgetTests()
    {
        //Arrange
        Shop shop1 = new Shop(1, "Магнит", "пр. Мира, 20");
        Shop shop2 = new Shop(2, "Пятерочка", "ул. Ершова, 50");
        Shop shop3 = new Shop(3, "Перекрёсток", "ул. Авангардная, 40");
        ShopsManager shopManager = new ShopsManager();
        shopManager.shops=[shop1,shop2,shop3];

        (Product Product, int Quanity, int Price)[] batchProducts =
        [
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
        ];
        int budget = 1000;
        List<(Shop Shop, Product Product, int NumberOfProducts)> productsWithInBudget = new()
        {
            (shop1,new Product(1, "ХЛЕБ"),22),
            (shop1,new Product(2, "МОЛОКО"),11),
            (shop1,new Product(3, "РИС"), 8),
            (shop1,new Product(4, "МАСЛО"),6),
            (shop1,new Product(5, "МЯСО"),2),
            (shop1,new Product(6, "РЫБА"),3),
            (shop1,new Product(7, "ЯЙЦА"),11),
            (shop1,new Product(8, "САХАР"),16),
            (shop1,new Product(9, "СОЛЬ"),33),
            (shop1,new Product(10, "КАРТОФЕЛЬ"),40)
        };

        //Act
        shop1.DeliveryBatchProducts(batchProducts);
        var result = shopManager.GetProductsWithInBudget(budget, shopManager.shops); 
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string expected = JsonSerializer.Serialize(result,options);
        string actual = JsonSerializer.Serialize(productsWithInBudget,options);
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
}
