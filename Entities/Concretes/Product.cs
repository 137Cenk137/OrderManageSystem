using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;

public class Product : BaseEntity<int>
{
    public float Price { get; set; }
    public string Type { get; set; }
    
}