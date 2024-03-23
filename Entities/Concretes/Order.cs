using System.ComponentModel.DataAnnotations.Schema;
using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;

public class Order: BaseEntity<int>
{
    
    public Customer Customer { get; set; }
    public int  CustomerId { get; set; }
    public string CustomerName { get; set; }

    [ForeignKey("Id")]//ProcuctId
    public Product Product { get; set; }
    public int  Amount { get; set; }
    public DateTime CreatedDate { get; set; }
}