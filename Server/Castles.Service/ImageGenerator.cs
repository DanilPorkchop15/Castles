using Castles.Domain.Entities.Image;

namespace Castles.Service;

public class ImageGenerator(ILogger<ImageGenerator> logger) {
    public async Task<Image> GenerateAsync(Image image, IFormFile imageContent) {
        logger.LogDebug("Generating image");
        var imageWithContent = image with { Content = await imageContent.GetBytes() };
        return imageWithContent;
    }
}
