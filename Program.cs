var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.MapGet("/little", () => "Hello Little Monkey World!  Meuw. CI/CD")
    .WithName("Little");

app.Run();
