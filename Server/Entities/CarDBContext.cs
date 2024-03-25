using Microsoft.EntityFrameworkCore;

namespace Server.Entities
{
    public class CarDBContext : DbContext
    {
        public DbSet<CarLetter> CarLetters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=RegionCodesDB;
                                        Integrated Security=True;
                                        Connect Timeout=5;
                                        Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarLetter>().HasData(new CarLetter[]
            {
                new CarLetter()
                {
                    Id = 1,
                    Region = "Krym",
                    Code = "AK",
                },
                new CarLetter()
                {
                    Id = 2,
                    Region = "Vinnitska Oblast",
                    Code = "AB",
                },
                new CarLetter()
                {
                    Id = 3,
                    Region = "Volynska Oblast",
                    Code = "AC",
                },
                new CarLetter()
                {
                    Id = 4,
                    Region = "Dnipropetrovska Oblast",
                    Code = "AE",
                },
                new CarLetter()
                {
                    Id = 5,
                    Region = "Donetska Oblast",
                    Code = "AH",
                },
                new CarLetter()
                {
                    Id = 6,
                    Region = "Shitomerska Oblast",
                    Code = "AM",
                },
                new CarLetter()
                {
                    Id = 7,
                    Region = "Sakarpatska Oblast",
                    Code = "AO",
                },
                new CarLetter()
                {
                    Id = 8,
                    Region = "Saporishka Oblast",
                    Code = "AP",
                },
                new CarLetter()
                {
                    Id = 9,
                    Region = "Ivano-Frankivska Oblast",
                    Code = "AT",
                },
                new CarLetter()
                {
                    Id = 10,
                    Region = "Kyiv",
                    Code = "AA",
                },
                new CarLetter()
                {
                    Id = 11,
                    Region = "Kyivska Oblast",
                    Code = "AI",
                },
                new CarLetter()
                {
                    Id = 12,
                    Region = "Kirovogradska Oblast",
                    Code = "BA",
                },
                new CarLetter()
                {
                    Id = 13,
                    Region = "Lyganska Oblast",
                    Code = "BB",
                },
                new CarLetter()
                {
                    Id = 14,
                    Region = "Lvivska Oblast",
                    Code = "BC",
                },
                new CarLetter()
                {
                    Id = 15,
                    Region = "Mukolaivska Oblast",
                    Code = "BE",
                },
                new CarLetter()
                {
                    Id = 16,
                    Region = "Odeska Oblast",
                    Code = "BH",
                },
                new CarLetter()
                {
                    Id = 17,
                    Region = "Poltavska Oblast",
                    Code = "BI",
                },
                new CarLetter()
                {
                    Id = 18,
                    Region = "Rivnenska Oblast",
                    Code = "BK",
                },
                new CarLetter()
                {
                    Id = 19,
                    Region = "Sevastopol",
                    Code = "CH",
                },
                new CarLetter()
                {
                    Id = 20,
                    Region = "Sumska Oblast",
                    Code = "BM",
                },
                new CarLetter()
                {
                    Id = 21,
                    Region = "Ternopilska Oblast",
                    Code = "BO",
                },
                new CarLetter()
                {
                    Id = 22,
                    Region = "Harkivska Oblast",
                    Code = "AX",
                },
                new CarLetter()
                {
                    Id = 23,
                    Region = "Hersonska Oblast",
                    Code = "BT",
                },
                new CarLetter()
                {
                    Id = 24,
                    Region = "Hmelnytska Oblast",
                    Code = "BX",
                },
                new CarLetter()
                {
                    Id = 25,
                    Region = "Cherkaska Oblast",
                    Code = "CA",
                },
                new CarLetter()
                {
                    Id = 26,
                    Region = "Chernigivska Oblast",
                    Code = "CB",
                },
                new CarLetter()
                {
                    Id = 27,
                    Region = "Chernivetska Oblast",
                    Code = "CE",
                }
            });
        }
    }
}
