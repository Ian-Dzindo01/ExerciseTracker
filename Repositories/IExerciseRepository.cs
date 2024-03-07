namespace ExerciseTracker;

public interface IExerciseRepository
{
    public List<Exercise> GetExercises();
    public bool InsertExercise(Exercise exercise);
    public bool UpdateExercise(Exercise exercise);
    public bool DeleteExercise(int id);
}