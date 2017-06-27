using Microsoft.EntityFrameworkCore;

namespace Сongratulation.Models
{
    public class CongratulationContext:DbContext
    {
    public DbSet<СongratulateUser> СongratulateUsers { get; set; }

    public CongratulationContext(DbContextOptions<CongratulationContext> options) : base(options) { }

  }
}
