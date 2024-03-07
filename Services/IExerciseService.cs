namespace ExerciseTracker;

public interface IExerciseService
{
    public List<Exercise> GetExercises();
    public bool UpdateExercise(Exercise exercise);
    public bool AddExercise(Exercise exercise);
    public bool DeleteExercise(int id);
}