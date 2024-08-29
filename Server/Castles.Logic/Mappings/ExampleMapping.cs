using Castles.Domain.Entities;
using Castles.Logic.ExampleUseCase.Commands.CreateExample;
using Mapster;

namespace Castles.Logic.Mappings;

public static class ExampleMapping {
    public static void Configure() {
        // Configure Product to ProductDto mapping
        _ = TypeAdapterConfig<ExampleEntity, CreateExampleRequest>.NewConfig()
            .Map(static dest => dest.Bebra, static src => src.Bebra);
        _ = TypeAdapterConfig<ExampleEntity, CreateExampleResponse>.NewConfig()
            .Map(static dest => dest.Bebra, static src => src.Bebra);
    }
}
