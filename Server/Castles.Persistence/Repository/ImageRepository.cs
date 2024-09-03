using Castles.Domain.Entities.Image;

namespace Castles.Persistence.Repository;

public class ImageRepository(CastlesDbContext dbContext) {
    public async Task InsertImageAsync(Image image) {
        _ = dbContext.Images.Add(image);
        _ = await dbContext.SaveChangesAsync();
    }
}
