using System.Text;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (var p in products)
        {
            total += p.GetTotalCost();
        }

        total += customer.IsInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("PACKING LABEL:");

        foreach (var p in products)
        {
            sb.AppendLine($"{p.GetName()}  (ID: {p.GetProductId()})");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("SHIPPING LABEL:");
        sb.AppendLine(customer.GetName());
        sb.AppendLine(customer.GetAddress().GetFullAddress());

        return sb.ToString();
    }
}
