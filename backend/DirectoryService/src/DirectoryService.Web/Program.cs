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

var dsn = builder.Configuration["POSTGRES_DSN"];

if (string.IsNullOrEmpty(dsn) || string.IsNullOrWhiteSpace(dsn))
    throw new InvalidOperationException("POSTGRES_DSN is not set in environment variables or appsettings.json");

builder.Services.AddPostgres(dsn);

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
