using OrderManageSystem.Core.DataAccess;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Abstracts;

public interface IStockDal : IEntityDal<Stock,int>
{
    
}