using Microsoft.EntityFrameworkCore;
namespace CRUD.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Menu> Items {get;set;}
    }
}