using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker;

public class ExerciseDbContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure SQLite database
        optionsBuilder.UseSqlite("Data Source=exercise.db");
    }

//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         // Configure the model, relationships, etc., if needed
//     }
}