using System.Security.Cryptography.X509Certificates;
using OrderManageSystem.DataAccess.Abstracts;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Concretes;

public class ProductDal : IProductDal
{
    private List<Product> _products;
    public ProductDal()
    {
        _products = new List<Product>();
    }
    public void Add(Product entity)
    {
        _products.Add(entity);
    }

    public void Edit(int id,Product entity)
    {
        var product =  _products.SingleOrDefault(x=>x.Id == id);
        product.Price = entity.Price;
        product.Type = entity.Type;
        
    }

    public Product GetById(int id)
    {
        var product =  _products.Where(p => p.Id == id).SingleOrDefault();

        return product;
    }
}