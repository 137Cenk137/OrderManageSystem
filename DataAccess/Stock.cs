class Stock
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int No { get; set; }
    public List<Product> Products { get; set; }


    public void Add(int id, float price, string type){
        Products.Add(new Product{Id = id, Price = price, Type=type});
    }
    public void Modify(int ProductIdId){
        
    }
    public void Select(int ProductIdId){}
}