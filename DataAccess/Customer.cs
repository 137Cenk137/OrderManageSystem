public class Customer 
{

    public Customer()
    {
        orders = new List<Order>();
    }
    public string Name { get; set; }
    public int Id { get; set; }

    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public List<Order> orders{ get; set; }

    public void Add(Order order){
        orders.Add(order);
    }
    public void Edit(Order order,int Id)
    {
        int index = orders.IndexOf(order);
        if (orders[index].Id== Id )
        {
            Console.WriteLine("dfg");
        }
    }
        
    
    public void Remove()
    {
        orders.Clear();
    }
}