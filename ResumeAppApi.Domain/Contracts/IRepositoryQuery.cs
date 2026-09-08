namespace ResumeAppApi.Domain.Contracts;

public interface IRepositoryQuery<TEntity> where TEntity : class
{
    IQueryable<TEntity> Query();
}
