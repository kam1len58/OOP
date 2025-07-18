using System.ComponentModel.Design;

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

    public List<(Product Product, int Quanity, int Price)> productSet = new();

    public void DeliveryBatchProducts(params (Product Product, int Quanity, int Price)[] products)
    {
        bool isSameProduct = false;
        for (int i=0;products.Length>i;i++)
        {
            for(int j=0;j<productSet.Count;j++)
            {
                if (products[i].Product.Code == productSet[j].Product.Code)
                {
                    productSet[j] = (products[i].Product, products[i].Quanity + productSet[j].Quanity, productSet[j].Price + products[i].Price);
                    isSameProduct = true;
                    break;
                }
            }
            if(!isSameProduct)
            {
                productSet.Add(products[i]);
            }
        }
    }
}
