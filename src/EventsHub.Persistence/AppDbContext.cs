using Microsoft.EntityFrameworkCore;
using EventsHub.Domain;

namespace EventsHub.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    public DbSet<Activity> Activities { get; set; }

}
