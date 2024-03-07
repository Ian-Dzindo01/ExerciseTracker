using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker;
public class ExerciseRepository(ExerciseDbContext pushUpContext) : IExerciseRepository
{
    public List<Exercise> GetExercises()
    {
        return pushUpContext.Exercises.ToList();
    }

    public bool InsertExercise(Exercise exercise)
    {
        pushUpContext.Exercises.Add(exercise);
        try
        {
            pushUpContext.SaveChanges();
        }
        catch(DbUpdateException)
        {   
            return false;
        }

        return true;
    }

    public bool UpdateExercise(Exercise exercise)
    {
        pushUpContext.Exercises.Update(exercise);
        try
        {
            pushUpContext.SaveChanges();
        }
        catch(DbUpdateException)
        {
            return false;
        }
        return true;
    }

    public bool DeleteExercise(int id)
    {
        var exercise = pushUpContext.Exercises.Find(id);
        if (exercise == null)
        {
            return false;
        }

        pushUpContext.Exercises.Remove(exercise);
        try
        {
            pushUpContext.SaveChanges();
        }
        catch(DbUpdateException)
        {
            return false;
        }
        return true;
    }
}