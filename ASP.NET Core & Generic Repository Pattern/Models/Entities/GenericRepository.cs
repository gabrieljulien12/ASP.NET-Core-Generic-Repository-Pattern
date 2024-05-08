using ASP.NET_Core___Generic_Repository_Pattern.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Entities
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntitiy
    {
        private readonly Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }
        public IQueryable<TEntity> GetAll()
        {
           return _context.Set<TEntity>().AsNoTracking();

        }
        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task Create(TEntity entity)
        {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
        }

        public async Task Uptade(int id, TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity   = await GetById(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
