using Castles.Domain.Entities.Image;
using Castles.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Castles.Persistence;

#pragma warning disable CS8618
public class CastlesDbContext(DbContextOptions<CastlesDbContext> options) : DbContext(options) {
    public DbSet<Image> Images { get; set; }
    public DbSet<ImageCategory> ImageCategories { get; set; }
    public DbSet<User> Users { get; set; }
#pragma warning restore CS8618
}
