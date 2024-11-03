using ClimaSprint2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClimaSprint2.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<ClimaEntity> Clima { get; set; }
    }
}
