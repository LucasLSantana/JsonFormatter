using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<JsonData> JsonData { get; set; }
    }
}
