using Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class StoreContext : DbContext //parang extends lang yan tas DbContext is from entity framework
    {
        public StoreContext( DbContextOptions<StoreContext> options) : base(options) 
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
//Microsoft.EntityFramework