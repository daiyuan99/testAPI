using BizModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace testAPI.DAL
{
    public class CoreDbContext: IdentityDbContext<AppUser>
    {
        public CoreDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Flock>().ToTable("Flock");

            base.OnModelCreating(builder);
        }

        public DbSet<Flock> Flocks { get; set; }
    }
}
