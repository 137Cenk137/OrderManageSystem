using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.Business.Abstracts;

public interface IProductServices {
     void Add(Product entity);
    

     void Edit(int id,Product entity);
    
     Product GetById(int id);
    
}