using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.UgniusFalze.Models;

public class ExerciseDbContext:DbContext
{
    public ExerciseDbContext(DbContextOptions<ExerciseDbContext> options)
        : base(options)
    {

    }
    public DbSet<Pushup> Pushups { get; set; }
}