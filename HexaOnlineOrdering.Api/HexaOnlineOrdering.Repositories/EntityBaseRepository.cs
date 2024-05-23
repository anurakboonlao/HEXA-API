using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HexaOnlineOrdering.Repositories
{
    public abstract class EntityBaseRepository<T, U> : IEntityBaseRepository<T,U> where T : class, new() where U : DbContext
    {
        private readonly DbContext _dbContext;
        public EntityBaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public void AddRange(List<T> entitys)
        {
            _dbContext.AddRange(entitys);
        }

        public async Task AddRangeAsync(List<T> entitys)
        {
            await _dbContext.AddRangeAsync(entitys);
        }

        public IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsEnumerable();
        }

        public async Task<IEnumerable<T>> AllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await Task.FromResult(query.AsEnumerable());
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public int Count()
        {
            return _dbContext.Set<T>().Count();
        }

        public void Delete(T entity)
        {
            EntityEntry dbEntity = _dbContext.Entry(entity);
            dbEntity.State = EntityState.Deleted;
        }

        public void DeleteRange(List<T> entitys)
        {
            foreach (T entity in entitys)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void DeleteWithCondition(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _dbContext.Set<T>().Where(predicate);
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _dbContext.Set<T>().FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return await Task.FromResult<T>(null);
        }

        public void Update(T entity)
        {
            EntityEntry dbEntity = _dbContext.Entry(entity);
            dbEntity.State = EntityState.Modified;
        }
    }
}
