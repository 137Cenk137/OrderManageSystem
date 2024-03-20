using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.Business.Abstracts;

public interface IStockService{
    void Add(Stock entity);
    
    void Edit(int id, Stock entity);
    

    Stock GetById(int id);
    
}