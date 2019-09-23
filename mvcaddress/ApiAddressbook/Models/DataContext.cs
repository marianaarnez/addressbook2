namespace ApiAddressbook.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiAddressbook.Models.Book> Books { get; set; }
    }
}