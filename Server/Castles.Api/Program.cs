using Castles.Logic;
using Castles.Logic.Images.Commands.CreateImage;
using MediatR;
using Castles.Persistence;
using Castles.Service;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
else {
    // _ = app.UseHttpsRedirection();
}

app.MapPost("/bebra", static async ([FromForm] CreateImageRequest request, IMediator mediator) => await mediator.Send(request)).DisableAntiforgery();

app.Run();

static void ConfigureServices(WebApplicationBuilder builder) {
    _ = builder.Services
        .AddEndpointsApiExplorer()
        .AddSwaggerGen()
        .AddPersistenceLayer()
        .AddServiceLayer()
        .AddLogicLayer();
}
