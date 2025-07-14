namespace Shop;

class Shop
{
    public int Code { get; }
    public string Name { get; }
    public string Address { get; }

    public Shop(int code, string name, string address)
    {
        Code = code;
        Name = name;
        Address = address;
    }

    List<(Product product, int quanity, int price)> productSet = new();

    public void DeliveryOfGoods(Product product, int quanity, int price)
    { 
        productSet.Add((product, quanity, price));
    } 
    
}
