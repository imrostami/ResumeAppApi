namespace ResumeAppApi.Domain.Contracts;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> DeleteAsync(int id);
    Task<TEntity> GetBy(int id);
    Task<IEnumerable<TEntity>> GetAll();



}
