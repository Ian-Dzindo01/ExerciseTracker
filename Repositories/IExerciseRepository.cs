namespace ExerciseTracker;

public interface IExerciseRepository
{
    public List<Pushup> GetExercises();
    public bool InsertExercise(Pushup pushup);
    public bool UpdateExercise(Pushup pushup);
    public bool DeleteExercise(int id);
}