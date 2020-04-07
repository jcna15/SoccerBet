using Microsoft.EntityFrameworkCore;
using SoccerBet.Web.Data.Entity;

namespace SoccerBet.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TeamEntity> Teams { get; set; }
    }

}
