namespace ExerciseTracker;

public class ExerciseController
{
    private readonly IExerciseService ExerciseService;

    public ExerciseController(IExerciseService exerciseService)
    {
        ExerciseService = exerciseService;
    }

    public List<Pushup> GetExercises()
    {
        return ExerciseService.GetExercises();
    }

    public bool AddExercise(Pushup pushup)
    {
        return ExerciseService.AddExercise(pushup);
    }

    public bool UpdateExercise(Pushup pushup)
    {
        return ExerciseService.UpdateExercise(pushup);
    }

    public bool DeleteExercise(int id)
    {
        return ExerciseService.DeleteExercise(id);
    }
}