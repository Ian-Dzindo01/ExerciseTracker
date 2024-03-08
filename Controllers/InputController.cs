namespace ExerciseTracker
{

    public class InputHelper
    {
        public static T GetInput<T>(string prompt)
        {
            Console.Write($"{prompt}: ");
            string input = Console.ReadLine();

            try
            {
                // Convert the input to the specified type
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input. Please enter a valid {typeof(T).Name}.");
                return GetInput<T>(prompt);
            }
        }

        public static Exercise GetExerciseInput()
        {
            var input = new Exercise();

            input.Name = GetInput<string>("Enter name of exercise");

            while(true)
            {
                input.DateStart = GetInput<DateTime>("Enter start date");
                input.DateEnd = GetInput<DateTime>("Enter end date");

                if (CheckDates(input.DateStart, input.DateEnd))
                    break;
            }
            
            input.Repetitions = GetInput<int>("Enter number of repetitions");

            input.Comment = GetInput<string>("Enter optional comment (press Enter to skip)");

            return input;
        }

        private static bool CheckDates(DateTime start, DateTime end)
        {
            if (start > end )
            {
                Console.WriteLine("Start date is greater than end date. Please try again.");
                return false;
            }
            else
                return true;
        }
    }
}