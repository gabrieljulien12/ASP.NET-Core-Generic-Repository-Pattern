using ASP.NET_Core___Generic_Repository_Pattern.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Entities
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(Context context) : base(context)
        {
        }
        public async Task<string> GetFirstName()
        {
            return await GetAll().Select(x => x.Name).FirstOrDefaultAsync();
        }
    }
}
