using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;

public class Stock : BaseEntity<int>
{
   public int ProductId { get; set; }
   public int Quantity { get; set; }
}