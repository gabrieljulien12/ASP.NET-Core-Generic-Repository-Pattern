using ASP.NET_Core___Generic_Repository_Pattern.Models.Entities;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Services
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<string> GetFirstName();
    }
}
