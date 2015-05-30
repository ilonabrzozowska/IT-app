using System.Collections.Generic;

namespace WebAp.IRepositories
{
    public interface IRepository<T>
    {
        T GetByID(object id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entitiesList);
        void Delete(object id);
        void Delete(T entityToDelete);
        IEnumerable<T> GetAll();
        void Update(T entityToUpdate);
        T Find(object id);
        void SaveChanges();
        void Dispose(bool disposing);

    }
}