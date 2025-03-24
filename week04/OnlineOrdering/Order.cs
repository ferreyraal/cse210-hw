public class Order
{
    private Customer _customer;
    private List<Product> _products; 

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GettotalOrder()
    {
        double subtotal = 0;
        double shipping = 0;
        foreach (var product in _products)
        {
            subtotal = subtotal + product.GetTotal();
        }
        if (_customer.LiveInUSA())
            {shipping = 5;}
        else
            {shipping = 35;}

        return subtotal+shipping;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }

    public string GetPackingLabel()
    {
        string packing_label = "";
        foreach (var product in _products)
        {
            packing_label = packing_label + product.GetProductInfo() + Environment.NewLine;
        }
        return packing_label;
    } 
}