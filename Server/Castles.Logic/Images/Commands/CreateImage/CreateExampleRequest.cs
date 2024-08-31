using Castles.Logic.ExampleUseCase.Commands.CreateImage;
using MediatR;

namespace Castles.Logic.Images.Commands.CreateImage;

public record class CreateImageRequest(IFormFile Content, String Folder, String Name, String CategoryName) : IRequest<CreateImageResponse>;
