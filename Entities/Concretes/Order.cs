using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;

public class Order: BaseEntity<int>
{
    public int  CustomerId { get; set; }
    public string CustomerName { get; set; }

    public int ProductId { get; set; }
    public int  Amount { get; set; }
    public DateTime CreatedDate { get; set; }
}