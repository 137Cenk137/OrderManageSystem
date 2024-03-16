using System.Security.Cryptography.X509Certificates;
using OrderManageSystem.DataAccess.Abstracts;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Concretes;

public class OrderDAl : IOrderDal
{
    private List<Order> _orders  = new List<Order>();
   

    public void Edit(int id, Order order)
    {
        var order1 = _orders.SingleOrDefault(x => x.Id == id);
        order1.Amount = order.Amount;
       
       
    }

    public void NewOrder(Order entity)
    {
        _orders.Add(entity);
    }

    public void OrderCompleted(int id)
    {
        
    }
}