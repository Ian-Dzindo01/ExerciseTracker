namespace ExerciseTracker;

public interface IExerciseService
{
    public List<Pushup> GetExercises();
    public bool UpdateExercise(Pushup pushup);
    public bool AddExercise(Pushup pushup);
    public bool DeleteExercise(int id);
}