namespace ExerciseTracker;

public class ExerciseService(IExerciseRepository exerciseRepository) : IExerciseService
{
    private readonly IExerciseRepository ExerciseRepository = exerciseRepository;
    
    public List<Pushup> GetExercises()
    {
        return ExerciseRepository.GetExercises();
    }

    public bool DeleteExercise(int id)
    {
        return ExerciseRepository.DeleteExercise(id);
    }

    public bool UpdateExercise(Pushup pushup)
    {
        return ExerciseRepository.UpdateExercise(pushup);
    }

    public bool AddExercise(Pushup pushup)
    {
        return ExerciseRepository.InsertExercise(pushup);
    }
    
}