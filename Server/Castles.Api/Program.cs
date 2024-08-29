using Castles.Logic;
using Castles.Logic.ExampleUseCase.Commands.CreateExample;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
else {
    _ = app.UseHttpsRedirection();
}

app.MapPost("/bebra", static async (CreateExampleRequest request, IMediator mediator) => {
    return await mediator.Send(request);
});

app.Run();

static void ConfigureServices(WebApplicationBuilder builder) {
    _ = builder.Services
        .AddEndpointsApiExplorer()
        .AddSwaggerGen()
        .AddLogicLayer();
}
