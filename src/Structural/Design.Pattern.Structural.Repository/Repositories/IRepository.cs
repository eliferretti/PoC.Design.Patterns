namespace Design.Pattern.Structural.Repository.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
