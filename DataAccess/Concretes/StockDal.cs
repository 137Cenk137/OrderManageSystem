using System.Security.Cryptography.X509Certificates;
using OrderManageSystem.DataAccess.Abstracts;
using OrderManageSystem.Entities.Concretes;

namespace OrderManageSystem.DataAccess.Concretes;

public class StockDal : IStockDal
{
    private List<Stock> _stocks;

    public StockDal()
    {
        _stocks = new();
    }
    public void Add(Stock entity)
    {
        _stocks.Add(entity);
    }

    public void Edit(int id, Stock entity)
    {
        var stock = _stocks.SingleOrDefault(s => s.Id == id);
        stock.Quantity = entity.Quantity;
        
    }

    public Stock GetById(int id)
    {
        var stock = _stocks.SingleOrDefault(s => s.Id == id);
        return stock;
    }
}

