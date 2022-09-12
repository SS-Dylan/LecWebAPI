using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models.Entities;

namespace WebAPIDemo.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Pet> Pets => Set<Pet>();
}