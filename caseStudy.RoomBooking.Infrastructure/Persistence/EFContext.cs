using Microsoft.EntityFrameworkCore;
using System;
using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Infrastructure.Persistence.Services;

namespace caseStudy.RoomBooking.Infrastructure.Persistence
{


    public class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EFContext(DbContextOptions contextOptions) : base(contextOptions) { }

        public EFContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Replace with your actual PostgreSQL connection string
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RoomBookingDb;Username=postgres;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Users"
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .HasConversion(
                    v => Guid.Parse(v),  // Convert string to Guid for database storage
                    v => v.ToString()    // Convert Guid back to string for application use
                )
                .HasValueGenerator<GuidStringGenerator>()  // Use the custom generator
                .ValueGeneratedOnAdd()  // Enable auto-generation
                .HasColumnType("uuid");
            #endregion
        }
    }
}