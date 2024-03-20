
using OrderManageSystem.Core.DataAccess;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Abstracts;

public interface IOrderDal
{

     void NewOrder(Order entity);
     void OrderCompleted(int id);

     void Edit(int id , Order order);
}