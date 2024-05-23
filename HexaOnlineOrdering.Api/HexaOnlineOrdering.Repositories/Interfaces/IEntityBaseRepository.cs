using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IEntityBaseRepository<T,U> where T : class, new() where U : DbContext
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> predicate);
        int Count();
        void Add(T entity);
        void AddRange(List<T> entitys);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(List<T> entitys);
        void DeleteWithCondition(Expression<Func<T, bool>> predicate);
        int Commit();
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);      

        // Asynchronous
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(List<T> entitys);
        Task<int> CommitAsync();
        Task<IEnumerable<T>> AllIncludingAsync(params Expression<Func<T, object>>[] includeProperties);
    }
}
