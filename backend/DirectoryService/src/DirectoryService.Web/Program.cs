using DirectoryService.Infrastructure.Postgres;
using DotNetEnv;
using Scalar.AspNetCore;

// Читаем .env
Env.TraversePath().Load();

var builder = WebApplication.CreateBuilder(args);

// Нативный OpenAPI .NET 9/10
builder.Services.AddOpenApi();

// Для тестового контроллера
builder.Services.AddControllers();

builder.Services.AddHealthChecks();

builder.Services.AddPostgres(builder.Configuration["POSTGRES_DSN"]!);

var app = builder.Build();

// Minimal API endpoints
app.MapGet("/", () => "TemplateService is running!");

// MVC контроллеры
app.MapControllers();

app.MapHealthChecks("/health");

if (!app.Environment.IsProduction())
{
    app.MapOpenApi();               // /openapi/v1.json
    app.MapScalarApiReference();    // /scalar/v1
}

await app.RunAsync();
