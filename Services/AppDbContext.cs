using Microsoft.EntityFrameworkCore;

namespace CrudProduct_ts.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
