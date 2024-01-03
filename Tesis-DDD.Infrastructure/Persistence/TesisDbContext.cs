using Api_DDD.Domain;
using Microsoft.EntityFrameworkCore;

namespace Tesis_DDD.Infrastructure.Persistence
{
    public class TesisDbContext : DbContext
    {
        public TesisDbContext(DbContextOptions<TesisDbContext> options) : base(options)
        {
        }
        //public DbSet<Project> Screens1 { get; set; }
        //public DbSet<useCase> UseCases { get; set; }
        //public DbSet<UseCaseAlgorith> UseCaseAlgoriths { get; set; }
        //public DbSet<Resultestimate> Resultestimates { get; set; }
        //public DbSet<ResultAlgorith> resultAlgoriths { get; set; }
        //public DbSet<algorithmCase> AlgorithmCases { get; set; }
        //public DbSet<expertEstimate> ExpertEstimates { get; set; }
        //public DbSet<estimationAlgorithm> EstimationAlgorithms { get; set; }
        //public DbSet<resourceList> ResourceLists { get; set; }
        //public DbSet<responsible>Responsibles{ get; set; }

    }
}
