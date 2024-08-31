using Castles.Logic;
using Castles.Logic.Images.Commands.CreateImage;
using MediatR;
using Castles.Persistence;
using Castles.Service;

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

app.MapPost("/bebra", static async (CreateImageRequest request, IMediator mediator) => await mediator.Send(request));

app.Run();

static void ConfigureServices(WebApplicationBuilder builder) {
    _ = builder.Services
        .AddPersistenceLayer()
        .AddEndpointsApiExplorer()
        .AddSwaggerGen()
        .AddServiceLayer()
        .AddLogicLayer();
}
