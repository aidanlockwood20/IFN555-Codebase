/*
 * Steps in code:
 * 
 * 1. Declare Base Rate, Hourly Rate, Mile Rate
 * 2. Ask User for the number of hours the job will take 
 * 3. Convert the input string to double 
 * 4. Ask User for the number of miles the job will take
 * 5. Convert the input string to double 
 * 6. Calculate the amount the job will take based on the values provided
 * 7. Display Final Result
 */

namespace MoveEstimator;

class MoveEstimator
{
    public static void Main(string[] args)
    {
        // Declare Base Rate, Hourly Rate, Mile Rate
        const int BASE_RATE = 200;
        const int HOUR_RATE = 150;
        const int MILE_RATE = 2;

        // Ask User for the number of hours the job will take 
        Console.WriteLine("How many hours will the move take?");
        string userPromptNumHours = Console.ReadLine();

        // Convert the input string to double 
        double jobNumHours = double.Parse(userPromptNumHours);

        // Ask User for the number of miles the job will take
        Console.WriteLine("How far away is the job from our location (in miles)?");
        string userPromptDistance = Console.ReadLine();

        // Convert the input string to double 
        double jobDistanceMiles = double.Parse(userPromptDistance);

        // Calculate the amount the job will take based on the values provided
        double CalculateMoveEstimation = BASE_RATE + (HOUR_RATE * jobNumHours) + (MILE_RATE * jobDistanceMiles);

        // Display Final Result
        Console.WriteLine("Based on the Hours and Distance Provided, the job will cost $ {0}", CalculateMoveEstimation);
    }
}