using System;
using System.Linq;

namespace MovieReviewSpa.Data.Contracts
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();

        T GetById(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
        void Delete(string id);
    }
}
