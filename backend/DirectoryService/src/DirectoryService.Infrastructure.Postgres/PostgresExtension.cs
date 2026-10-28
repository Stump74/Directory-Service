using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DirectoryService.Infrastructure.Postgres;

public static class PostgresExtension
{
    public static void AddPostgres(this IServiceCollection services, string dsn)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(dsn));

        services.AddHealthChecks()
            .AddDbContextCheck<AppDbContext>();
    }
}