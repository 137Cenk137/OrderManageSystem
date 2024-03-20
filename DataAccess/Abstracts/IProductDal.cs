using OrderManageSystem.Core.DataAccess;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Abstracts;

public interface IProductDal : IEntityDal<Product,int>
{

}