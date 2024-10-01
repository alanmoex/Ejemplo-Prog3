using Domain.Interfaces;

namespace Infrastructure.Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private static List<T> Entities = new List<T>();

        public List<T> GetAll()
        {
            return Entities;
        }

        public T GetById(int id)
        {
            return Entities[id];
        }

        public void Add(T entity) 
        {

            Entities.Add(entity);
        }

        public void Update(int id, T entity) 
        {
            Entities[id] = entity;
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }
    }
}
