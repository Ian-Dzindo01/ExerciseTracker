using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker;
public class ExerciseRepository(ExerciseDbContext pushUpContext) : IExerciseRepository
{
    public List<Pushup> GetExercises()
    {
        return pushUpContext.Pushups.ToList();
    }

    public bool InsertExercise(Pushup pushup)
    {
        pushUpContext.Pushups.Add(pushup);
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

    public bool UpdateExercise(Pushup pushup)
    {
        pushUpContext.Pushups.Update(pushup);
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
        var exercise = pushUpContext.Pushups.Find(id);
        if (exercise == null)
        {
            return false;
        }

        pushUpContext.Pushups.Remove(exercise);
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