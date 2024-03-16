
using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;


public class Customer : BaseEntity<int>
{
    
    public  string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
} 