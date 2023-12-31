using Microsoft.EntityFrameworkCore;
using BicycleInventory.Model;

namespace BicycleInventory.DBContext
{
    public class BicycleDbContext : DbContext
    {
        public DbSet<MBicycle> Bicycles { get; set; }
        public DbSet<MFrame> Frames { get; set; }
        public DbSet<MPedals> Pedals { get; set; }
        public DbSet<MSeat> Seats { get; set; }
        public DbSet<MTyre> Tyres { get; set; }
        public DbSet<MWheelFrame> WheelFrames { get; set; }
        public DbSet<MWheels> Wheels { get; set; }

        public BicycleDbContext(DbContextOptions<BicycleDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MFrame>()
                .Property(f => f.quantity)
                .IsRequired();

            modelBuilder.Entity<MPedals>()
                .Property(p => p.quantity)
                .IsRequired();

            modelBuilder.Entity<MSeat>()
                .Property(s => s.quantity)
                .IsRequired();

            modelBuilder.Entity<MTyre>()
                .Property(t => t.quantity)
                .IsRequired();

            modelBuilder.Entity<MWheelFrame>()
                .Property(wf => wf.quantity)
                .IsRequired();

            // Add other configurations...

            base.OnModelCreating(modelBuilder);
        }
    }
}
