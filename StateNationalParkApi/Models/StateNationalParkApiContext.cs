using Microsoft.EntityFrameworkCore;

namespace StateNationalParkApi.Models
{
  public class StateNationalParkApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    
    public StateNationalParkApiContext(DbContextOptions<StateNationalParkApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, ParkName = "Crater Lake", ParkState = "Oregon", StateOrNational = "National" },
        new Park { ParkId = 2, ParkName = "Yosemite", ParkState = "California", StateOrNational = "National" },
        new Park { ParkId = 3, ParkName = "Champoeg", ParkState = "Oregon", StateOrNational = "State" }
      );
    }
  }
}