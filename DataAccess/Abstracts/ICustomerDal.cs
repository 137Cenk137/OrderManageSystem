using System.ComponentModel;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Abstracts;

public interface ICustomerDal
{
    void Add(Customer customer);
    void Edit();
    void Delete(int id);
    List<Customer> GetAll();

}