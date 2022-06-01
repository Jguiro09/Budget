using Budget.Portal.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Portal.Database
{
    public class BudgetDbContext : DbContext
    {
        public BudgetDbContext(DbContextOptions<BudgetDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost; Initial Catalog=budget-application;Persist Security Info=False; User ID=SA;Password=1.password.1");
        }
    }
}