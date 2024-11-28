using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace LeadTrack.Infrastructure.dataBase
{
    public class LeadTrackContextFactory : IDesignTimeDbContextFactory<LeadTrackContext>
    {
        public LeadTrackContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LeadTrackContext>();
            optionsBuilder.UseSqlServer("Data Source=INVENT125\\B1;User ID=sa;Password=sap@123;Initial Catalog=Lead;Encrypt=False");

            return new LeadTrackContext(optionsBuilder.Options);
        }
    }
}
