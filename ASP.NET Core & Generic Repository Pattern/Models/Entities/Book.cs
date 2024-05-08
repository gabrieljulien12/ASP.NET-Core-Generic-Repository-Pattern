using System.Security.Cryptography.X509Certificates;

namespace ASP.NET_Core___Generic_Repository_Pattern.Models.Entities
{
    public class Book : BaseEntitiy
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
