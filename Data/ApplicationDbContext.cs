using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LRSIceRink.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<Skate> Skates { get; set; }
        public DbSet<SkateUsage> SkatesUsage { get; set; }
        public DbSet<Property> Properties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Property>().HasData(
                new Property { Id = Guid.NewGuid(), Name = "WarnSkateUsageMinutes", Value = "180" },
                new Property { Id = Guid.NewGuid(), Name = "MaxSkateUsageMinutes", Value = "240" }
            );
            base.OnModelCreating(modelBuilder);
        }
        }
}