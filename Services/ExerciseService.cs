namespace ExerciseTracker;

public class ExerciseService(IExerciseRepository exerciseRepository) : IExerciseService
{
    private readonly IExerciseRepository ExerciseRepository = exerciseRepository;
    
    public List<Exercise> GetExercises()
    {
        return ExerciseRepository.GetExercises();
    }

    public bool DeleteExercise(int id)
    {
        return ExerciseRepository.DeleteExercise(id);
    }

    public bool UpdateExercise(Exercise exercise)
    {
        return ExerciseRepository.UpdateExercise(exercise);
    }

    public bool AddExercise(Exercise exercise)
    {
        return ExerciseRepository.InsertExercise(exercise);
    }
    
}