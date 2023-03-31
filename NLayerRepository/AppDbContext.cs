using Microsoft.EntityFrameworkCore;
using NLayerCore.Model;

namespace NLayerRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
       
    }
}