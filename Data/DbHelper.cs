using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker;

public class ExerciseDbContext:DbContext
{
    public ExerciseDbContext(DbContextOptions<ExerciseDbContext> options)
        : base(options)
    {

    }
    public DbSet<Exercise> Exercises { get; set; }
}