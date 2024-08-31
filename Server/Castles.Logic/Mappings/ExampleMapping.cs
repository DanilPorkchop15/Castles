using Castles.Domain.Entities;
using Castles.Domain.Entities.Image;
using Castles.Logic.Images.Commands.CreateImage;
using Mapster;

namespace Castles.Logic.Mappings;

public static class ExampleMapping {
    public static void Configure() {
        // Configure Product to ProductDto mapping
        _ = TypeAdapterConfig<Image, CreateImageRequest>.NewConfig()
            .Map(static dest => dest.Folder, static src => src.Folder)
            .Map(static dest => dest.Name, static src => src.Name)
            .Map(static dest => dest.CategoryName, static src => src.Category.Name);
    }
}
