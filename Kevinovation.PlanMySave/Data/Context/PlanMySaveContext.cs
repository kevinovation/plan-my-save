using Kevinovation.PlanMySave.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kevinovation.PlanMySave.Data.Context
{
    public class PlanMySaveContext : DbContext
    {
        public PlanMySaveContext(DbContextOptions<PlanMySaveContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        private DbSet<Revenu> Revenus { get; set; }
        private DbSet<Expense> Expenses { get; set; }
        private DbSet<Currency> Currencies { get; set; }
    }
}