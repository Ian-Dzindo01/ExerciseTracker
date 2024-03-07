namespace ExerciseTracker;

public class ExerciseController
{
    private readonly IExerciseService ExerciseService;

    public ExerciseController(IExerciseService exerciseService)
    {
        ExerciseService = exerciseService;
    }

    public List<Exercise> GetExercises()
    {
        return ExerciseService.GetExercises();
    }

    public bool AddExercise(Exercise exercise)
    {
        return ExerciseService.AddExercise(exercise);
    }

    public bool UpdateExercise(Exercise exercise)
    {
        return ExerciseService.UpdateExercise(exercise);
    }

    public bool DeleteExercise(int id)
    {
        return ExerciseService.DeleteExercise(id);
    }
}