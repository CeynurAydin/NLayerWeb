using Microsoft.EntityFrameworkCore;
using NLayerCore.Repositories;
using NLayerCore.Services;
using System.Linq.Expressions;


namespace NLayerService
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        

        public Service(IGenericRepository<T> repository)
        {
            _repository = repository;
            
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            return entities; ;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
          _repository.Remove(entity);
           
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
           
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
           
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
