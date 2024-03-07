using System;

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
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1: Create a New Entry");
            Console.WriteLine("2: View a Session");
            Console.WriteLine("3: Update Session Data");
            Console.WriteLine("4: Delete a Session");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddExercise(exerciseController);
                    break;
                case "2":
                    // ShowExercise(exerciseController);
                    break;
                case "3":
                    // Console.WriteLine("Id of contact you would like to update: ");
                    // int id1 = int.Parse(Console.ReadLine());
                    // Controller.Update(id1);
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
        }

        private static void DeleteExercise(ExerciseController exerciseController)
        {
            Console.WriteLine("Id of contact you would like to delete: ");
            int id = int.Parse(Console.ReadLine());
            exerciseController.DeleteExercise(id);
        }
    }
}