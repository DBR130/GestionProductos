using Microsoft.EntityFrameworkCore;
using GestiónProductos.Models;

namespace GestiónProductos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Productos> Productos { get; set; }
    

    }
}
