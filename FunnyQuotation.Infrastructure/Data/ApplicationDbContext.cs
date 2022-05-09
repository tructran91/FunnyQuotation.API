using FunnyQuotation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FunnyQuotation.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Quotation> Quotations { get; set; }

        //public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SerilogEntity> Serilog { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
