
public class Program
{
    private static void Main(string[] args)
    {
        Customer customer= new Customer(){
            Id = 12,
            Name="Cenk",
            PhoneNumber  ="1234567876543",
            Address = "gazile mahallesi"

        };

        Order order1= new Order(){ Id= 11,CustomerName = customer.Name, CustomerId  = customer.Id,Date = DateTime.Now.Date ,Amount = 2 };
        Order order2= new Order(){ CustomerName = customer.Name, CustomerId  = customer.Id,Date = DateTime.Now.Date , Amount= 3 };

    
        customer.Add(order1);
        customer.Add(order2);


        foreach (var item in customer.orders)
        {
            Console.WriteLine(item.CustomerName);
        }
        customer.Edit(order1,11);


    }
}