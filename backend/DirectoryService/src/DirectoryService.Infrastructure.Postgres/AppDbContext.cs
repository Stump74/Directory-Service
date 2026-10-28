using Microsoft.EntityFrameworkCore;

namespace DirectoryService.Infrastructure.Postgres;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options);