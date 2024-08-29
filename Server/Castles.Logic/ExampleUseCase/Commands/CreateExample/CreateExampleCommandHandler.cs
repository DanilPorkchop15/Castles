using Castles.Domain.Entities;
using MapsterMapper;
using MediatR;

namespace Castles.Logic.ExampleUseCase.Commands.CreateExample;

public class CreateExampleCommandHandler(IMapper mapper) : IRequestHandler<CreateExampleRequest, CreateExampleResponse> {
    public Task<CreateExampleResponse> Handle(CreateExampleRequest request, CancellationToken cancellationToken) {
        var entity = mapper.Map<ExampleEntity>(request);

        /* ну кароче чота тут саздается да понял да разные там вещи да + запросы к базе данных */

        var response = mapper.Map<CreateExampleResponse>(entity);
        response.Bebra += ", no eto otvet";
        return Task.FromResult(response);
    }
}

