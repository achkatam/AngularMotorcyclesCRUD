namespace MotorcyclesAPI.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class MotorcycleContext : DbContext
{
    public MotorcycleContext(DbContextOptions<MotorcycleContext> options) : base(options) { }

    // Use Set of motorcycle to prevent warnings
    public DbSet<Motorcycle> Motorcycles { get; set; }
}