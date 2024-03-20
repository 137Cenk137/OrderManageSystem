using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.Business.Abstracts;

public interface IOrderService{

     void Edit(int id, Order order);
    

    
    void NewOrder(Order entity);
    

     void OrderCompleted(int id);
    
}