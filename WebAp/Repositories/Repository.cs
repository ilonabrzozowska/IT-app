using System.Collections.Generic;
using System.Linq;
using WebAp.IRepositories;
using System.Data.Entity;
using DataLayer.Models;

namespace WebAp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ThreeTierContext context;
        protected DbSet<T> dbSet;

        public Repository()
        {
            this.context = new ThreeTierContext();
            this.dbSet = context.Set<T>();
        }

        public Repository(ThreeTierContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        /// <summary>
        /// Getting object by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetByID(object id)
        {
            return dbSet.Find(id);
        }
        /// <summary>
        /// Adding new object
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }
        /// <summary>
        /// Deleting object by id
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            T entity = dbSet.Find(id);
            Delete(entity);
        }
        public virtual T Find(object id)
        {
            T entity = dbSet.Find(id);
            return entity;
        }

        /// <summary>
        /// Deleting object by entity
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == System.Data.Entity.EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
        /// <summary>
        /// Getting list of all objects
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }
        /// <summary>
        /// Updating object
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = System.Data.Entity.EntityState.Modified;
        }
        /// <summary>
        /// Saving changes to database
        /// </summary>
        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }
        public virtual void AddRange(IEnumerable<T> entitiesList)
        {
            dbSet.AddRange(entitiesList);
        }
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            this.Dispose(disposing);
        }

    }
}