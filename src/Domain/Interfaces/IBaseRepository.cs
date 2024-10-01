namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        private static List<T> Entities = new List<T>();
        public List<T> GetAll();
        public T GetById(int id);
        public void Add(T entity);
        public void Update(int id,T entity);
        public void Delete(T entity);
    }
}
