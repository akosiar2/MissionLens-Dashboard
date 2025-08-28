using Microsoft.EntityFrameworkCore;

namespace MissionLensData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
