using System;
using Spectre.Console;

namespace ExerciseTracker
{
    public class Menu
    {
        private readonly ExerciseController exerciseController;

        public Menu(ExerciseController exerciseController)
        {
            this.exerciseController = exerciseController;
        }

        public void Start()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("1: Create a New Entry");
            Console.WriteLine("2: View all Sessions");
            Console.WriteLine("3: Update Session Data");
            Console.WriteLine("4: Delete a Session");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddExercise(exerciseController);
                    break;
                case "2":
                    ShowExercise(exerciseController);
                    break;
                case "3":
                    break;
                case "4":
                    DeleteExercise(exerciseController);
                    break;
                default:
                    Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                    break;
            }
        }

        private static void AddExercise(ExerciseController exerciseController)
        {
            Exercise newExercise = InputHelper.GetExerciseInput();

            bool success = exerciseController.AddExercise(newExercise);

            if (success)
            {
                Console.WriteLine("Successfully added new exercise.");
            }
            else
            {
                Console.WriteLine("Failed to add new exercise. Please check the input and try again.");
                AddExercise(exerciseController);
            }

            // May not be the best approach. CHANGE.
            Menu menu = new Menu(exerciseController);
            menu.Start();        
        }

        private static void DeleteExercise(ExerciseController exerciseController)
        {
            Console.WriteLine("Id of entry you would like to delete: ");
            int id = int.Parse(Console.ReadLine());
            exerciseController.DeleteExercise(id);

            // May not be the best approach. CHANGE.
            Menu menu = new Menu(exerciseController);
            menu.Start();        }

        private static void ShowExercise(ExerciseController exerciseController)
        {
            List<Exercise> exercises = exerciseController.GetExercises();
            foreach (var w in exercises)
            {
                Console.WriteLine(@$"Id: {w.Id} Name: {w.Name} Start Time: {w.DateStart} End Time: {w.DateEnd} 
                                    Repetitions: {w.Repetitions} Duration: {w.Duration}");
            }

            // May not be the best approach. CHANGE.
            Menu menu = new Menu(exerciseController);
            menu.Start();
        }
    }
}