using M.Entity.Products;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MyFinanceApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Incomes> Incomes { get; set; }
        public DbSet<Expenses> Expenses { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
