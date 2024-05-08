using ASP.NET_Core___Generic_Repository_Pattern.Models.Services;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Entities
{
    public class BaseEntitiy : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
