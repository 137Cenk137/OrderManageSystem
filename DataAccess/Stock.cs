class Stock
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int No { get; set; }
    public List<Product> Products { get; set; }


    public void Add(int id, float price, string type){
        Products.Add(new Product{Id = id, Price = price, Type=type});
    }
    public void Modify(int productIdId,Product product,int newId,float price)
    {
        int index = Products.IndexOf(product);
        if(Products[index].Id == productIdId)
        {
            Products[index].Id = newId;
            Products[index].Price = price;
        }
    }
    public Product Select(int ProductIdId){
        for (int i = 0; i < Products.Count; i++)
        {
            if (Products[i].Id == ProductId)
            {
                return Products[i];
            }
        
        }
        return null;
    }
}