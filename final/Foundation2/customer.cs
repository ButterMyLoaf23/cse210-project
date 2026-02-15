public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    public string Name()
    {
        return _name;
    }

    public string Address()
    {
        return _address.GetFullAddress();
    }
}