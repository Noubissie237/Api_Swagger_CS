using Microsoft.EntityFrameworkCore;

namespace FirstApiWithCSharp.Models
{
    public class UniteApiContext : DbContext
    {
        public UniteApiContext(DbContextOptions<UniteApiContext> options) : base(options)
        {
        }
        public DbSet<UniteApiContext> uniteApiContexts { get; set; }
    }
}
