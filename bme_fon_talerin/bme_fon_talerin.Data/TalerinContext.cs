using bme_fon_talerin.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace bme_fon_talerin.Data
{
    public class TalerinContext : BaseContext
    {
        //$env:ASPNETCORE_ENVIRONMENT='Local'
        //dotnet ef migrations add V1 -c TalerinContext -p bme_fon_talerin.Data -s bme_fon_talerin --verbose
        //dotnet ef database update -c TalerinContext -p bme_fon_talerin.Data -s bme_fon_talerin --verbose
        //dotnet ef migrations remove -c TalerinContext -p bme_fon_talerin.Data -s bme_fon_talerin --verbose

        public DbSet<Sudoku> Sudokus { get; set; }
        public DbSet<SudokuRule> SudokuRules { get; set; }
        public DbSet<Rule> Rules { get; set; }

        public TalerinContext() { }
        public TalerinContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options) { }
        public TalerinContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
