using System.ComponentModel.DataAnnotations.Schema;
using OrderManageSystem.Core.Entities;

namespace OrderManageSystem.Entities.Concretes;

public class Stock : BaseEntity<int>
{
   
   
   public int Quantity { get; set; }

   [ForeignKey("Id")]//ProcuctId
   public Product product { get; set; }

}