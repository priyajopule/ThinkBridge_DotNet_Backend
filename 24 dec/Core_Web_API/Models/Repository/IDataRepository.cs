using System.Collections.Generic;

namespace Core_Web_API.Models.Repository
{
    public interface IDataRepository
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }

    public class TEntity
    {
    }
}
