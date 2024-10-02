namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> GetAll();
        public T? GetById<TId>(TId id);
        public void Add(T entity);
        public void Update(int id,T entity);
        public void Delete(T entity);
    }
}
