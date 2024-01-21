class Order {
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }


    public void NewOrder(){}
    public void Edit(int Id){}
    

}