using System.Linq;

namespace JanHoffmann.Red.Data.DataStoring.Contract
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> Query { get; }
    }
}
