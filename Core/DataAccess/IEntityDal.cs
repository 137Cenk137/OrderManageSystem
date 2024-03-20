namespace OrderManageSystem.Core.DataAccess;

public interface IEntityDal<T,Tint>
{
    void Add (T entity);
    void Edit(Tint id,T entity);
    T GetById(Tint id);
}