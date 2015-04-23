using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebAp.Models;
using WebAp.IRepositories;
using WebAp.Repositories;

namespace WebAp.Repositories
{

    /// <summary>
    /// Creating new Factory
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TRepository"></typeparam>
    /// <returns></returns>
    public class RepositoryFactory
    {
        
        WebApRepositories repositories;
        WebApContext db;
        public RepositoryFactory(WebApContext dbContext)
        {
            repositories = new WebApRepositories();
            this.db = dbContext;
        }

        /// <summary>
        /// Creates new instance of Repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Create<T>() where T : class
        {
            //Dla DropAndCreateDatabasie należy użyć poniższej lini kodu
          //  RepositoryComponentInfo repositoryComponentInfo = repositories.Repositories.Where(q => q.Name == typeof(T).Name.Replace("InformationRepository", "").Replace("Repository", "")).FirstOrDefault();

            RepositoryComponentInfo repositoryComponentInfo = repositories.Repositories.Where(q => q.Service == typeof(T)).FirstOrDefault();
            if (repositoryComponentInfo == null || repositoryComponentInfo.Implementation == null)
                throw new Exception(String.Format("No implementation for {0} service", typeof(T).ToString()));

            return Activator.CreateInstance(repositoryComponentInfo.Implementation,db) as T;
        }

    }


}