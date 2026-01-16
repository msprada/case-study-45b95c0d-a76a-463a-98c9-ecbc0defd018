namespace caseStudy.RoomBooking.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using caseStudy.RoomBooking.Domain.Entities;

    public class EFContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public EFContext(DbContextOptions contextOptions) : base(contextOptions) { }

        public EFContext() : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region "Users"
            modelBuilder.Entity<User>()
                .Property(x => x.Id).HasDefaultValue(Guid.NewGuid().ToString());
            #endregion
        }
    }
}