using System.Security.Cryptography.X509Certificates;
using OrderManageSystem.DataAccess.Abstracts;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Concretes;

public class CustomerDal : ICustomerDal
{

    List<Customer> _customers = new();
    public void Add(Customer customer)
    {
        _customers.Add(customer);
    }

    public void Delete(int id)
    {
        var customer = _customers.SingleOrDefault(x=>x.Id == id);
        _customers.Remove(customer);

    }

    public void Edit()
    {
        
    }

    public List<Customer> GetAll()
    {
        return _customers;
    }
}