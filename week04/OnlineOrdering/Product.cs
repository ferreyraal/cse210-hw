public class Product
{
    private string _productId = "";
    private string _product = "";
    private double _price = 0;
    private int _quantity = 0;

    public Product(string productId, string product, double price, int quantity)
    {   
        _productId = productId;
        _product = product;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotal()
    {
        double total = _quantity * _price;
        return total;
    }

    public string GetProductInfo()
    {
        return $"{_productId} - {_product}";
    }
}


