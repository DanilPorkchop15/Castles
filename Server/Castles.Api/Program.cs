var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}
else {
    _ = app.UseHttpsRedirection();
}
app.Run();
