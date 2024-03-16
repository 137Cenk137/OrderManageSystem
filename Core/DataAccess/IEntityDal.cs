namespace OrderManageSystem.Core.DataAccess;

public interface IEntityDal<T>
{
    void Add (T entity);
}