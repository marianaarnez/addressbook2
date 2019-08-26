
namespace mvcaddress.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<mvcaddress.Models.Book> Books { get; set; }
    }
}