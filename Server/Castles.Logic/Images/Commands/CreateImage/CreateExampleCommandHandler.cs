using Castles.Domain.Entities.Image;
using Castles.Logic.ExampleUseCase.Commands.CreateImage;
using Castles.Persistence.Repository;
using Castles.Service;
using MapsterMapper;
using MediatR;

namespace Castles.Logic.Images.Commands.CreateImage;

public class CreateImageCommandHandler(IMapper mapper, FileStorage fileStorage, ImageGenerator imageGenerator, ImageRepository imageRepository) : IRequestHandler<CreateImageRequest, CreateImageResponse> {
    public async Task<CreateImageResponse> Handle(CreateImageRequest request, CancellationToken cancellationToken) {
        // var image = mapper.Map<Image>(request); //todo
        var image = new Image(0, request.Folder, request.Name, new ImageCategory(0, request.CategoryName));
        var content = request.Content;
        image = await imageGenerator.GenerateAsync(image, content);
        // await imageRepository.InsertImageAsync(image with { Content = null });
        await fileStorage.Upload(image.Content!, image.FullName, Random.Shared.Next());
        return new CreateImageResponse(Results.Ok("Bebra"));
    }
}

