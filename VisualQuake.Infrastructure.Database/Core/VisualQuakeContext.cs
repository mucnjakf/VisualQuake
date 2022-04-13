namespace VisualQuake.Infrastructure.Database.Core;

public class VisualQuakeContext : DbContext
{
    public DbSet<Earthquake> Earthquakes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=VisualQuakeDb;User Id=sa;Password=SQL;");
}
