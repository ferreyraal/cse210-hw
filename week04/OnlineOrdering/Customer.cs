public class Customer
{
    private string _name = "";
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerInfo()
    {
        return $"Customer: {_name} {Environment.NewLine}{_address.GetFullAddress()}";
    }
}