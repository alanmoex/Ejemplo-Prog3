using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;
        public BaseRepository(DbContext context) 
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById<TId>(TId id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity) 
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(int id, T entity) 
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
