using MediatR;

namespace Castles.Logic.ExampleUseCase.Commands.CreateExample;

public class CreateExampleRequest : IRequest<CreateExampleResponse> {
    public String? Bebra { get; set; }
}

