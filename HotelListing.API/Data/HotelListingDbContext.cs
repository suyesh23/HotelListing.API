using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext :DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id =1,
                    Name ="India",
                    ShortName ="IN"
                },
                new Country
                {
                    Id=2,
                    Name ="Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id=3,
                    Name ="United States Of America",
                    ShortName ="USA"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                 new Hotel
                 {
                     Id = 1,
                     Name = "TAJ",
                     Address="Mumbai",
                     CountryId=1,
                     Rating=7
                 },
               new Hotel
               {
                   Id = 2,
                   Name = "Oberoi",
                   Address = "Mumbai",
                   CountryId = 1,
                   Rating = 7
               },
                new Hotel
                {
                    Id = 3,
                    Name = "Sandals Resorts ans Spa",
                    Address = "Negril",
                    CountryId = 2,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 4,
                     Name = "Grand Palladium",
                     Address = "California",
                     CountryId = 3,
                     Rating = 7
                 }
                );
        }
    }
}
