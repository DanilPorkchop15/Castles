using Castles.Domain.Entities.Image;
using Castles.Logic.Images.Commands.CreateImage;
using Castles.Persistence.Repository;
using Castles.Service;
using MapsterMapper;
using MediatR;

namespace Castles.Logic.ExampleUseCase.Commands.CreateImage;

public class CreateImageCommandHandler(IMapper mapper, ImageGenerator imageGenerator, ImageRepository imageRepository) : IRequestHandler<CreateImageRequest, CreateImageResponse> {
    public Task<CreateImageResponse> Handle(CreateImageRequest request, CancellationToken cancellationToken) {
        var image = mapper.Map<Image>(request);
        var content = request.Content;

        /* ну кароче чота тут саздается да понял да разные там вещи да + запросы к базе данных */

        return Task.FromResult(new CreateImageResponse(Results.Ok("bebra")));
    }
}

