using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.Data;

public class AIGSContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<SpendingDetail> SpendingDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AIGSDatabase;Integrated Security=True;");

        optionsBuilder.LogTo(Console.WriteLine, new[]{ DbLoggerCategory.Database.Name }, Microsoft.Extensions.Logging.LogLevel.Information);
    }
}

