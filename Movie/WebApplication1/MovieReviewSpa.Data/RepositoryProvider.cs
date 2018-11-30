using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

/*namespace MovieReviewSpa.Data
{
    public class RepositoryProvider //: IRepositoryProvider
    {
        private RepositoryFactories _repositoryFactories;
        public MovieReviewDbContext DbContext { get; set; }
        protected Dictionary<Type, object> Repositories { get; private set; }
        
        public RepositoryProvider(RepositoryFactories repositoryFactories)
        {
            _repositoryFactories = repositoryFactories;
            Repositories = new Dictionary<Type, object>();
        }

        public IRepository<T> GetRepositoryForEntityType<T>() where T : class
        {
            return GetRepository<IRepository<T>>(_repositoryFactories.GetRepositoryFactoryForEntityType<T>());
        }

        

        public virtual T GetRepository<T>(Func<MovieReviewDbContext, object> factory = null) where T : class
        {
            object repObj;
            Repositories.TryGetValue(typeof(T), out repObj);
            if(repObj != null)
            {
                return (T)repObj;
            }

            return MakeRepository<T>(factory, DbContext);
        }

        protected T MakeRepository<T>(Func<MovieReviewDbContext, object> factory, MovieReviewDbContext dbContext)
        {
            var f = factory ?? _repositoryFactories.GetRepositoryFactory<T>();
            if(f == null)
            {
                throw new NotImplementedException("No factory for repository type, " + typeof(T).FullName);
            }
            var repo = (T)f(dbContext);
            Repositories[typeof(T)] = repo;
            return repo;
        }
        

        public void SetRepository<T>(T repository)
        {
            Repositories[typeof(T)] = repository;
        }
    }
}*/
