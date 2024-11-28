using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace LeadTrack.Infrastructure.dataBase
{
    public class LeadTrackContextFactory : IDesignTimeDbContextFactory<LeadTrackContext>
    {
        public LeadTrackContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LeadTrackContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RCN2RNI;Initial Catalog=Lead;User ID=sa;Password=leia1234;Encrypt=False");

            return new LeadTrackContext(optionsBuilder.Options);
        }
    }
}
