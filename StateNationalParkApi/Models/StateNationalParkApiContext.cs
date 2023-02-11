using Microsoft.EntityFrameworkCore;

namespace StateNationalParkApi.Models
{
  public class StateNationalParkApiContext : DbContext
  {
    public DbSet<StateNationalPark> StateNationalParks { get; set; }
    
    public StateNationalParkApiContext(DbContextOptions<StateNationalParkApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<StateNationalPark>()
      .HasData(
        new StateNationalPark { ParkId = 1, ParkName = "Crater Lake", ParkState = "Oregon", StateOrNational = "National" },
        new StateNationalPark { ParkId = 2, ParkName = "Yosemite", ParkState = "California", StateOrNational = "National" },
        new StateNationalPark { ParkId = 3, ParkName = "Champoeg", ParkState = "Oregon", StateOrNational = "State" }
      );
    }
  }
}