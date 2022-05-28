using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaretAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}