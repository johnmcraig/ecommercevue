using ecommercevue.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommercevue.Data
{
    public class EcommerceDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EcommerceDbContext (DbContextOptions<EcommerceDbContext> options) : base (options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Product>()
                .HasIndex(b => b.Slug)
                .IsUnique();
        }
    }
}