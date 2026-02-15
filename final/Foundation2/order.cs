
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {

        double total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.PackingInfo();
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name()} {_customer.Address}";
    }
}