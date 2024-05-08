using ASP.NET_Core___Generic_Repository_Pattern.Models.Entities;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Services
{
    public interface IRepository<TEntity> where TEntity : BaseEntitiy
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById (int id);
        Task Create (TEntity entity);
        Task Uptade (int id,TEntity entity);
        Task Delete (int id);
    }
}
