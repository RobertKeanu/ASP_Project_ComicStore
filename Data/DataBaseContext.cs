using ASP_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Buy> Buys { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Comics> Comics { get; set; }

        public DbSet<ComicStore> ComicStore { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<Rent> Rent { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///One to one
            modelBuilder.Entity<ComicStore>()
                .HasOne(o => o.Location)
                .WithOne(o => o.ComicStore)
                .HasForeignKey<ComicStore>(o => o.LocationID);

            ///One to many
            modelBuilder.Entity<ComicStore>()
                .HasMany(o => o.Comics)
                .WithOne(o => o.ComicStore);

            ///Many to many
            modelBuilder.Entity<Rent>()
                .HasKey(o => new { o.MagazineID, o.PersonID });

            modelBuilder.Entity<Rent>()
                .HasOne(o=>o.Comic)
                .WithMany(o=>o.Rents)
                .HasForeignKey(o=>o.MagazineID);

            modelBuilder.Entity<Rent>()
                .HasOne(o => o.NewUser)
                .WithMany(o => o.Rents)
                .HasForeignKey(o => o.PersonID);
            ///Many to many buys
            modelBuilder.Entity<Buy>()
               .HasKey(o => new { o.MagazineID, o.PersonID });

            modelBuilder.Entity<Buy>()
                .HasOne(o => o.Comic)
                .WithMany(o => o.Buys)
                .HasForeignKey(o => o.MagazineID);

            modelBuilder.Entity<Buy>()
                .HasOne(o => o.NewUser)
                .WithMany(o => o.Buys)
                .HasForeignKey(o => o.PersonID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
