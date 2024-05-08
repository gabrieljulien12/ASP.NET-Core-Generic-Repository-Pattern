namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Services
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}
