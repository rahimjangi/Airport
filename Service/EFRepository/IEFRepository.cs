namespace Airport.Service.EFRepository
{
    public interface IEFRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> GetByName(string name);
        Task<T> Update(int id, T entity);
        Task<T> UpdateByEntity(T entity);
        Task DeleteById(int id);
        Task DeleteByName(string name);
        Task DeleteRange();      
    }
}
