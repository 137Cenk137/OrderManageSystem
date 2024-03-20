using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.Business.Abstracts;

public interface ICustomerService{

     void Add(Customer customer);
    

     void Delete(int id);
    

     void Edit();
    List<Customer> GetAll();
   

}