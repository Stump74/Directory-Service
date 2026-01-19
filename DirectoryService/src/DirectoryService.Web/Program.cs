using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Directory Service API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Michael",
            Email = "mishu@mail.ru",
        },
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Directory Service API");
    options.RoutePrefix = "swagger/v1";
});

app.MapControllers();
app.Run();
