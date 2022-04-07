using Microsoft.EntityFrameworkCore;

namespace Web.BE.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Model.Entities.Training> Trainings{ get; set; }
    }
}
