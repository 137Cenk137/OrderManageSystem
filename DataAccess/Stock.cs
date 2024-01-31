class Stock
{
    public Stock()
    {
        Products = new List<Product>();
    }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int No { get; set; }
    public List<Product> Products { get; set; }


    public void Add(int id, float price, string type){
        Products.Add(new Product{Id = id, Price = price, Type=type});
    }
    public void Modify(int productIdId,int newId,float price)
    {
        for (int i = 0; i < Products.Count; i++)
        {
             if(Products[i].Id == productIdId)
            {
            Products[i].Id = newId;
            Products[i].Price = price;
            }
            else{
                Console.WriteLine("there is no prouduct id");
            }
        }
        
    }
    public Product Select(int ProductIdId){
        for (int i = 0; i < Products.Count; i++)
        {
            if (Products[i].Id == ProductIdId)
            {
                return Products[i];
                
            }
        
        }
        
        return null;
        
    }
}