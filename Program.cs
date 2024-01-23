
public class Program
{
    private static void Main(string[] args)
    {

        Stock stock= new Stock(){
            ProductId = 12,
            Quantity = 1000,
            
        };
        Customer customer= new Customer(){
            Id = 12,
            Name="Cenk",
            PhoneNumber  ="1234567876543",
            Address = "gazile mahallesi"

        };

        Order order1= new Order(){ Id= 11,CustomerName = customer.Name, CustomerId  = customer.Id,Date = DateTime.Now.Date ,Amount = 2 };
        Order order2= new Order(){ CustomerName = customer.Name, CustomerId  = customer.Id,Date = DateTime.Now.Date , Amount= 3 };

        stock.Add(33,1000,"bilgisayar");
        stock.Add(11,10000,"televizyon");
        customer.Add(order1);
        customer.Add(order2);
        bool x  = true;

        while(x)
        {
            Console.WriteLine("Which query would you like to choose ? \n 1: Change Stock Setting \n 2: Change order setting ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(b == 1){
                Console.WriteLine("Which field would you like to change ? \n 1: added product \n 2: Modify stock \n 3: select product");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1){
                    Console.Write("product id enter :");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("product price enter :");
                    float e = float.Parse(Console.ReadLine());
                    Console.Write("product type enter :");
                    string f = Console.ReadLine();
                    stock.Add(d,e,f);
                    foreach (var item in stock.Products)
                    {
                        Console.WriteLine($"id : {item.Id} , price: {item.Price}, type: {item.Type}");
                    }
                    
                }
               

            }




            x = false;
        }
        


    }
}