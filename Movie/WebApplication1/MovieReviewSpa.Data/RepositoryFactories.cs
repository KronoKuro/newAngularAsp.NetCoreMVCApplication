using Microsoft.EntityFrameworkCore;
using MovieReviewSpa.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieReviewSpa.Data
{
  /*  public class RepositoryFactories
    {
        private readonly IDictionary<Type, Func<MovieReviewDbContext, object>> _repositoryFactories;

        private IDictionary<Type, Func<MovieReviewDbContext, object>> GetMovieReviewFactories()
        {
            return new Dictionary<Type, Func<MovieReviewDbContext, object>>
                {
                   {typeof(IRepository<>), dbContext => new RepositoryFactories()}

                };
        }


        public RepositoryFactories()
        {
            _repositoryFactories = GetMovieReviewFactories();
        }

        public RepositoryFactories(IDictionary<Type, Func<MovieReviewDbContext, object>> factories)
        {
            _repositoryFactories = factories;
        }
        public Func<MovieReviewDbContext, object> GetRepositoryFactory<T>()
        {

            Func<MovieReviewDbContext, object> factory;
            _repositoryFactories.TryGetValue(typeof(T), out factory);
            return factory;
        }

        public Func<MovieReviewDbContext, object> GetRepositoryFactoryForEntityType<T>() where T : class
        {
            return GetRepositoryFactory<T>() ?? DefaultEntityRepositoryFactory<T>();
        }

        protected virtual Func<MovieReviewDbContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new EFRepository<T>(dbContext);
        }
        


    }*/
}
