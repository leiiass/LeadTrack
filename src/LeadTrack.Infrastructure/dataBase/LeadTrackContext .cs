using LeadTrack.Domain.models;
using Microsoft.EntityFrameworkCore;

namespace LeadTrack.Infrastructure.dataBase
{
    public class LeadTrackContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public LeadTrackContext(DbContextOptions<LeadTrackContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lead>().HasData(
                new Lead
                {
                    Id = 5577421,
                    ContactFirstName = "Bill",
                    DateCreated = new DateTime(2023, 1, 4, 2, 37 ,0),
                    Suburb = "Yanderra 2574",
                    Category = "Painters",
                    Description = "Need to paint 2 aluminum windows and a sliding glass door",
                    Price = 62.00m,
                },
                new Lead
                {
                    Id = 5588872,
                    ContactFirstName = "Craig",
                    DateCreated = new DateTime(2023, 1, 4, 1, 15, 0),
                    Suburb = "Woolooware 2230",
                    Category = "Interior Painters",
                    Description = "Internal walls 3 colours",
                    Price = 49.00m,
                },
                new Lead
                {
                    Id = 5141895,
                    ContactFirstName = "Pete",
                    ContactPhoneNumber = "041235678",
                    ContactEmail = "fake@mailinator.com",
                    DateCreated = new DateTime(2018, 9, 5, 10, 36, 0),
                    Suburb = "Woolooware 2230",
                    Category = "Interior Painters",
                    Description = "Plaster exposed brick walls (see photos), square off 2 archways (see photos), and expand pantry (see photos).",
                    Price = 49.00m,
                },
                new Lead
                {
                    Id = 5121931,
                    ContactFirstName = "Cris",
                    ContactFullName = "Sanderson",
                    ContactEmail = "another.fake@hipmail.com",
                    ContactPhoneNumber = "04987654321",
                    DateCreated = new DateTime(2018, 8, 30, 11, 14, 0),
                    Suburb = "Quinns Rocks 6030",
                    Category = "Home Renovations",
                    Description = "There is a two story building at the front of the main house that's about 10x5 that would like to convert into self contained living area.",
                    Price = 32.00m,
                }
            );
        }
    }
}
