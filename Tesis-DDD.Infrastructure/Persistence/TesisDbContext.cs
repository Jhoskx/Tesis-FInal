using Api_DDD.Domain;
using Microsoft.EntityFrameworkCore;

namespace Tesis_DDD.Infrastructure.Persistence
{
    public class TesisDbContext : DbContext
    {
        public TesisDbContext(DbContextOptions<TesisDbContext> options) : base(options)
        {
        }
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet <Methodology> Methodologies { get; set; }
        //public DbSet <useCase> UseCases { get; set; }
    }
}
